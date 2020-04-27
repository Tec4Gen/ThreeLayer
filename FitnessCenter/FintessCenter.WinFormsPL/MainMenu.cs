using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintessCenter.WinFormsPL
{
    public partial class MainMenu : Form
    {
        public delegate void GridClient(IEnumerable<Client> clients);
        public delegate void GridCoach(IEnumerable<Coach> coachs);
        public delegate void GridCoachShow(Coach coachs);

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
            HallForm hallform = new HallForm();
            hallform.Show();
            dataGridViewCoach.Visible = false;
            dataGridViewClient.Visible = false;
            dataGridViewLessons.Visible = false;
            dataGridViewHall.Visible = true;
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            LessonsForm lessonform = new LessonsForm();
            lessonform.Show();
            dataGridViewCoach.Visible = false;
            dataGridViewHall.Visible = false;
            dataGridViewClient.Visible = false;
            dataGridViewLessons.Visible = true;
        }
    }
}
