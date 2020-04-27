using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using static FintessCenter.WinFormsPL.MainMenu;

namespace FintessCenter.WinFormsPL
{
    public partial class CoachForm : Form
    {
        private ICoachLogic coachlogic = DependenciesResolver.CoachLogic;
        GridCoach _gridCoach;
        GridCoachShow _gridcoachshow;


        public CoachForm(GridCoach gridcoach,GridCoachShow gridcoachshow)
        {
            this._gridCoach = gridcoach;
            this._gridcoachshow = gridcoachshow;
            InitializeComponent();
        }
        public CoachForm()
        {
            InitializeComponent();
        }

        private void CoachForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGetAllCoach_Click(object sender, EventArgs e)
        {
            var CoachGetDataBase = coachlogic.GetAll();
            if (CoachGetDataBase.Count() > 0)
            {
                _gridCoach(CoachGetDataBase);
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Тренеров нет";
                callbackMessage.Show();
            }
        }

        private void btnGetByLastNameCoach_Click(object sender, EventArgs e)
        {
            string LastName = textBoxGetByLastNameCoach.Text;

            if (LastName.Length >= 2)
            {
                var CoachGetDataBase = coachlogic.GetByLastName(LastName);
                if (CoachGetDataBase.Count() > 0)
                {
                    _gridCoach(CoachGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Тренеров c такой фамилией нет";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Поле не может содержать менее 2 символов";
                callbackMessage.Show();
            }
        }

        private void btnDeleteCoach_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxDeletePhoneCoach.Text, out long Phone) != false)
            {
                var CoachDeleted = coachlogic.Delete(Phone);
                if (CoachDeleted != null)
                {
                    var CoachGetDataBase = coachlogic.GetAll();
                    _gridCoach(CoachGetDataBase);
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = $"Тренер удален: {CoachDeleted.Id}|" +
                                                    $"{CoachDeleted.LastName}|" +
                                                    $"{CoachDeleted.FirstName}|" +
                                                    $"{CoachDeleted.Phone}|";

                    callbackMessage.Show();

                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Такого тренера нет";
                    callbackMessage.Show();
                }
            }
        }

        private void btnGetByPhoneCoach_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxGetByPhoneCoach.Text, out long Phone) != false)
            {
                var Coach = coachlogic.GetByPhone(Phone);
                if (Coach != null)
                {
                    _gridcoachshow(Coach);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Такого тренера нет";
                    callbackMessage.Show();
                }
            }
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxAddPhoneCoach.Text, out long phonecoach) != false)
            {
                Coach Coach = new Coach()
                {
                    FirstName = textBoxAddLastNameCoach.Text,
                    LastName = textAddFirstNameCoach.Text,
                    MiddleName = textBoxAddMiddleNameCoach.Text,
                    Phone = phonecoach
                };

                string AddCoach = coachlogic.Add(Coach);
                var CoachGetDataBase = coachlogic.GetAll();
                _gridCoach(CoachGetDataBase);

                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = AddCoach;
                callbackMessage.Show();
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введен не корректный номер телефона";
                callbackMessage.Show();
            }
        }

        private void lableAddPhoneCoach_Click(object sender, EventArgs e)
        {

        }
    }
}
