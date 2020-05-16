using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using static FintessCenter.WinFormsPL.MainMenu;

namespace FintessCenter.WinFormsPL
{
    public partial class HallForm : Form
    {
        private IHallLogic halllogic = DependenciesResolver.HallLogic;
        private GridHall _gridHall;
        private GridHallShow _gridHallShow;

        public HallForm()
        {
            InitializeComponent();
        }
        public HallForm(GridHall gridhall, GridHallShow gridhallshow)
        {
            _gridHall = gridhall;
            _gridHallShow = gridhallshow;
            InitializeComponent();
        }

        private void btnGetAllHall_Click(object sender, EventArgs e)
        {
            var HallGetDataBase = halllogic.GetAll();
            if (HallGetDataBase.Count() > 0)
            {
                _gridHall(HallGetDataBase);
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Залов нет";
                callbackMessage.Show();
            }
        }

        private void btnGetByHallName_Click(object sender, EventArgs e)
        {
            string HallName = textBoxGetByNameHall.Text;

            if (HallName.Length >= 2)
            {
                var Hall = halllogic.GetByName(HallName);
                if (Hall != null)
                {
                    _gridHallShow(Hall);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Зала с таким названием нет";
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

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            Hall Hall = new Hall() 
            {
                NameHall = textBoxAddNameHall.Text,
                Description = textBoxDescriptionHall.Text,
            };

            string AddHall = halllogic.Add(Hall);

            CallBackForm callbackMessage = new CallBackForm();
            callbackMessage.ErrorMessage = AddHall;
            callbackMessage.Show();
        }

        private void btnDeleteHallName_Click(object sender, EventArgs e)
        {
            if (textBoxNameHall.Text.Length >= 2)
            {
                var HallDeleted = halllogic.Delete(textBoxNameHall.Text);
                if (HallDeleted != null)
                {
                    var HallGetDataBase = halllogic.GetAll();
                    _gridHall(HallGetDataBase);

                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = $"Зал удален: {HallDeleted.Id}|" +
                                                    $"{HallDeleted.NameHall}|" +
                                                    $"{HallDeleted.Description}|";
                    callbackMessage.Show();
                }
                else 
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Такого зала нет";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введите корректное название зала";
                callbackMessage.Show();
            }
        }

        private void HallForm_Load(object sender, EventArgs e)
        {

        }
    }
}
