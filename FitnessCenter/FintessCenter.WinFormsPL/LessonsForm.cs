using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using static FintessCenter.WinFormsPL.MainMenu;

namespace FintessCenter.WinFormsPL
{
    public partial class LessonsForm : Form
    {
        private ILessonsLogic lessonslogic = DependenciesResolver.LessonsLogic;

        private GridLessons _gridlessons;
        private GridLessonsShow _gridlessonshow;



        public LessonsForm()
        {
            InitializeComponent();
        }
        public LessonsForm(GridLessons gridlessons, GridLessonsShow gridlessonshow)
        {
            _gridlessons = gridlessons;
            _gridlessonshow = gridlessonshow;
            InitializeComponent();
        }

        private void btnGetAllLessons_Click(object sender, EventArgs e)
        {
            var LessonGetDataBase = lessonslogic.GetAll();

            if (LessonGetDataBase.Count() > 0)
            {
                _gridlessons(LessonGetDataBase);
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Занятий нет";
                callbackMessage.Show();
            }
        }

        private void btnGetLessonById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxIdLessons.Text,out int idlesson)!= false) 
            {
                Lesson Lesson = new Lesson();

                Lesson = lessonslogic.GetById(idlesson);
                if (Lesson != null)
                {
                    _gridlessonshow(Lesson);
                }
                else 
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Занятий нет";
                    callbackMessage.Show();
                }
            }
        }

        private void btnAlllessonByPhoneCoach_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxLessonByPhoneCoach.Text, out long phonecoach) != false)
            {
                var LessonGetDataBase = lessonslogic.GetAllLessonByPhoneCoach(phonecoach);
                if (LessonGetDataBase.Count() > 0)
                {
                    _gridlessons(LessonGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "У тренера нет занятий";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректный номер телефона";
                callbackMessage.Show();
            }
        }

        private void btnGetAllLessonSubNumClient_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxLessonBySubNumClient.Text, out int subnum) != false)
            {
                var LessonGetDataBase = lessonslogic.GetAllLessonBySubNumClient(subnum);
                if (LessonGetDataBase.Count() > 0)
                {
                    _gridlessons(LessonGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "У клиента нет занятий";
                    callbackMessage.Show();
                }
            }
            else 
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректный номер абонимента";
                callbackMessage.Show();
            }
        }

        private void btnGetAllLessonsByHallName_Click(object sender, EventArgs e)
        {
            if (textBoxLessonByHallName.Text.Length >= 2)
            {
                var LessonGetDataBase = lessonslogic.GetAllLessonByNameHall(textBoxLessonByHallName.Text);
                if (LessonGetDataBase.Count() > 0)
                {
                    _gridlessons(LessonGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "В зале нет занятий";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Название зала не может быть меньше 2 символов";
                callbackMessage.Show();
            }
        }

        private void btnEmploymentAllHallByDate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(dateTimeEmploymentAllHallByDate.Text, "M/d/yyyy", null);
            var LessonGetDataBase = lessonslogic.EmploymentAllHallByDate(date);
            if (LessonGetDataBase.Count() > 0)
            {
                _gridlessons(LessonGetDataBase);
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Занятий на данную дату нет";
                callbackMessage.Show();
            }
        
        }

        private void btnEmploymentAllHallByDateTime_Click(object sender, EventArgs e)
        {
            string Date = dateTimeEmploymentAllHallByDate_.Text + " " + dateTimeEmploymentAllHallByDateTime.Text;
            DateTime date = DateTime.Parse(Date);
            var LessonGetDataBase = lessonslogic.EmploymentAllHallByDateTime(date);
            if (LessonGetDataBase.Count() > 0)
            {
                _gridlessons(LessonGetDataBase);
            }
            else
            {
                _gridlessons(LessonGetDataBase);
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Занятий на данную дату и время нет";
                callbackMessage.Show();
            }
        }

        private void btnEmploymentHallByDate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dateTimeEmploymentIdHallByDate.Text, out int idhall) != false)
            {
                DateTime date = DateTime.ParseExact(dateTimeEmploymentHallByDate.Text, "M/d/yyyy", null);
                var LessonGetDataBase = lessonslogic.EmploymentHallByDate(date, idhall);
                if (LessonGetDataBase.Count() > 0)
                {
                    _gridlessons(LessonGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Занятий на данную дату в данном зале нет";
                    callbackMessage.Show();
                }
            }
            else 
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректный номер зала";
                callbackMessage.Show();
            }
        }
        
        private void btnEmploymentHallByDateTime_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dateTimeEmploymentIdHallByDate_.Text, out int idhall) != false)
            {
                string Date = dateTimeEmploymentHallByDate_.Text + " " + dateTimeEmploymentHallByDateTime.Text;
                DateTime date = DateTime.Parse(Date);
                var Lesson = lessonslogic.EmploymentHallByDateTime(date, idhall);
                if (Lesson != null) 
                {
                    _gridlessonshow(Lesson);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Занятий на данную дату в данном зале и время нет";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректный номер зала";
                callbackMessage.Show();
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAddLessonIdClient.Text, out int idclient) != false)
            {
                if (int.TryParse(textBoxAddLessonIdHall.Text, out int idhall) != false)
                {
                    string Date = dateTimeAddLessonDate.Text + " " + dateTimeAddLessonTime.Text;
                    Lesson Lesson = new Lesson()
                    {
                        IdClinet = idclient,
                        IdHall = idhall,
                        Time = DateTime.Parse(Date),
                    };

                    string AddLesson = lessonslogic.Add(Lesson);

                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = AddLesson;
                    callbackMessage.Show();
                }
                else 
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Введите корректный id зала";
                    callbackMessage.Show();
                }
            }
            else 
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректный id клиента";
                callbackMessage.Show();
            }
        }
    }
}
