using PracticeCRUD_FORM.Logics;
using PracticeCRUD_FORM.Models;
using System.Security.Cryptography.X509Certificates;

namespace PracticeCRUD_FORM
{
    public partial class Form1 : Form
    {
        List<CourseSchedule> schedules;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoomManager roomManager = new RoomManager();
            CourseManager courseManager = new CourseManager();

            cbCourseCode.DisplayMember = "CourseCode";
            cbCourseCode.ValueMember = "CourseId";
            cbCourseCode.DataSource = courseManager.GetCourses();

            cbRoomCode.DisplayMember = "RoomCode";
            cbRoomCode.ValueMember = "RoomId";
            cbRoomCode.DataSource = roomManager.GetRoom();

            LoadDataForDataGridView();
        }

        private void LoadDataForDataGridView()
        {
            CourseScheduleManager csm = new CourseScheduleManager();
            schedules = csm.GetCourseSchedules();
            dgvOutput.DataSource = schedules
                .Select(x => new
                {
                    x.TeachingScheduleId,
                    RoomCode = x.Room.RoomId,
                    CourseCode = x.Course.CourseId,
                    x.TeachingDate,
                    x.Slot,
                    x.Description
                }).ToList();
        }

        private CourseSchedule GetCourseScheduleInfo()
        {
            CourseSchedule cs = new CourseSchedule();
            cs.CourseId = Convert.ToInt32(cbCourseCode.SelectedValue);
            cs.RoomId = Convert.ToInt32(cbRoomCode.SelectedValue);
            cs.TeachingDate = dtpTeachingDate.Value;
            cs.Slot = Convert.ToInt32(tbSlot.Text);
            cs.Description = tbDescription.Text;
            return cs;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            CourseSchedule currentCourse = schedules[e.RowIndex];
            tbTeachingScheduleID.Text = currentCourse.CourseId.ToString();
            tbDescription.Text = currentCourse.Description;
            tbSlot.Text = currentCourse.Slot.ToString();
            cbRoomCode.SelectedValue = currentCourse.RoomId;
            cbCourseCode.SelectedValue = currentCourse.CourseId;
            dtpTeachingDate.Value = currentCourse.TeachingDate.Value;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            CourseScheduleManager cs = new CourseScheduleManager();
            cs.AddCourseScedule(GetCourseScheduleInfo());
            LoadDataForDataGridView();
        }


        private void btnDELETE_Click(object sender, EventArgs e)
        {
            int courseScheduleId = 0;
            if (tbTeachingScheduleID.Text != String.Empty)
            {
                courseScheduleId = Convert.ToInt32(tbTeachingScheduleID.Text);
            }
            CourseScheduleManager csm = new CourseScheduleManager();
            csm.Delete(courseScheduleId);
            LoadDataForDataGridView();
        }



        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            tbTeachingScheduleID.Text = String.Empty;
            tbDescription.Text = String.Empty;
            tbSlot.Text = String.Empty;
            cbCourseCode.SelectedIndex = 0;
            cbRoomCode.SelectedIndex = 0;

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            CourseSchedule cs = GetCourseScheduleInfo();
            if (tbTeachingScheduleID != null)
            {
                cs.TeachingScheduleId = Convert.ToInt32(tbTeachingScheduleID.Text);
            }
            CourseScheduleManager csm = new CourseScheduleManager();
            csm.Edit(cs);
            LoadDataForDataGridView();
        }
    }
}
