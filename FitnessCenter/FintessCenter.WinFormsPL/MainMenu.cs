
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FintessCenter.WinFormsPL
{
    public partial class MainMenu : Form
    {

        public delegate void GridClient(IEnumerable<Client> clients);

        public delegate void GridCoach(IEnumerable<Coach> coachs);
        public delegate void GridCoachShow(Coach coachs);

        public delegate void GridHall(IEnumerable<Hall> halls);
        public delegate void GridHallShow(Hall hall);

        public delegate void GridLessons(IEnumerable<Lesson> lessons);
        public delegate void GridLessonsShow(Lesson lesson);

        public void GridViewClient(IEnumerable<Client> clients)
        {
            dataGridViewClient.Rows.Clear();
            foreach (var item in clients)
            {

                dataGridViewClient.Rows.Add(item.Id,
                                            item.LastName,
                                            item.FirstName,
                                            item.MiddleName,
                                            item.SubscriptionNumber,
                                            item.IDCoach);

            }

        }

        public void GridViewCoach(IEnumerable<Coach> coachs)
        {
            dataGridViewCoach.Rows.Clear();
            foreach (var item in coachs)
            {

                dataGridViewCoach.Rows.Add(item.Id,
                                            item.LastName,
                                            item.FirstName,
                                            item.MiddleName,
                                            item.Phone);
            }
        }

        public void GridViewShowCoach(Coach coachs)
        {
            dataGridViewCoach.Rows.Clear();
            dataGridViewCoach.Rows.Add(coachs.Id,
                                        coachs.LastName,
                                        coachs.FirstName,
                                        coachs.MiddleName,
                                        coachs.Phone);
        }

        public void GridViewHall(IEnumerable<Hall> hall)
        {
            dataGridViewHall.Rows.Clear();
            foreach (var item in hall)
            {
                dataGridViewHall.Rows.Add(item.Id,
                                            item.NameHall,
                                            item.Description);
            }
        }

        public void GridViewShowHall(Hall hall)
        {
            dataGridViewHall.Rows.Clear();
            dataGridViewHall.Rows.Add(hall.Id,
                                        hall.NameHall,
                                        hall.Description);
        }

        public void GridViewLessons(IEnumerable<Lesson> lessons)
        {
            dataGridViewLessons.Rows.Clear();
            foreach (var item in lessons)
            {
                dataGridViewLessons.Rows.Add(item.Id,
                                            item.IdClinet,
                                            item.IdHall,
                                            item.Time);
            }

        }

        public void GridViewShowLesson(Lesson lesson)
        {
            dataGridViewLessons.Rows.Clear();

            dataGridViewLessons.Rows.Add(lesson.Id,
                                        lesson.IdClinet,
                                        lesson.IdHall,
                                        lesson.Time);
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }




        private void BtnClient_Click(object sender, EventArgs e)
        {
            GridClient gridclient = GridViewClient;
            ClientForm clientform = new ClientForm(gridclient);

            clientform.Owner = this;
            clientform.Show();
            dataGridViewCoach.Visible = false;
            dataGridViewHall.Visible = false;
            dataGridViewLessons.Visible = false;
            dataGridViewClient.Visible = true;
        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            GridCoach gridcoach = GridViewCoach;
            GridCoachShow gridcoachshow = GridViewShowCoach;
            CoachForm coachform = new CoachForm(gridcoach, gridcoachshow);
            coachform.Owner = this;
            coachform.Show();
            dataGridViewHall.Visible = false;
            dataGridViewLessons.Visible = false;
            dataGridViewClient.Visible = false;
            dataGridViewCoach.Visible = true;
        }

        private void bntHall_Click(object sender, EventArgs e)
        {
            GridHall gridhall = GridViewHall;
            GridHallShow gridhallshow = GridViewShowHall;
            HallForm hallform = new HallForm(gridhall, gridhallshow);
            hallform.Owner = this;
            hallform.Show();
            dataGridViewCoach.Visible = false;
            dataGridViewClient.Visible = false;
            dataGridViewLessons.Visible = false;
            dataGridViewHall.Visible = true;
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            GridLessons gridlessons = GridViewLessons;
            GridLessonsShow gridshowlesson = GridViewShowLesson;
            LessonsForm lessonform = new LessonsForm(gridlessons, gridshowlesson);
            lessonform.Owner = this;
            lessonform.Show();
            dataGridViewCoach.Visible = false;
            dataGridViewHall.Visible = false;
            dataGridViewClient.Visible = false;
            dataGridViewLessons.Visible = true;
        }

        private void dataGridViewLessons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
