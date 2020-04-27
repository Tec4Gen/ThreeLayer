using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FintessCenter.WinFormsPL;
using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using static FintessCenter.WinFormsPL.MainMenu;

namespace FintessCenter.WinFormsPL
{
    public partial class ClientForm : Form
    {
        private IClientLogic clientlogic = DependenciesResolver.ClientLogic;

        GridClient _gridClient;
        public ClientForm()
        {
            InitializeComponent();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
        public ClientForm(GridClient gridclient)
        {
            this._gridClient = gridclient;
            InitializeComponent();
        }
        private void btnGetAllClient_Click(object sender, EventArgs e)
        {
            var ClientGetDataBase = clientlogic.GetAll();
            if (ClientGetDataBase.Count() > 0)
            {
                _gridClient(ClientGetDataBase);
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Клиентов нет";
                callbackMessage.Show();
            }
        }


        private void btnGetByLastNameClient_Click(object sender, EventArgs e)
        {
            string LasftName = textBoxGetByLastNameClient.Text;

            if (LasftName.Length >= 2)
            {
                var ClientGetDataBase = clientlogic.GetByLastName(LasftName);
                if (ClientGetDataBase.Count() > 0)
                {
                    _gridClient(ClientGetDataBase);
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Клиентов c такой фамилией нет";
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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxDeleteSubNum.Text, out int SubNumber) != false)
            {
                var ClientDeleted = clientlogic.Delete(SubNumber);
                if (ClientDeleted != null)
                {
                    var ClientGetDataBase = clientlogic.GetAll();
                    _gridClient(ClientGetDataBase);
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = $"Клиент удален: {ClientDeleted.Id}|" +
                                                    $"{ClientDeleted.LastName}|" +
                                                    $"{ClientDeleted.FirstName}|" +
                                                    $"{ClientDeleted.SubscriptionNumber}|" +
                                                    $"{ClientDeleted.IDCoach}";

                    callbackMessage.Show();

                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Такого клиента нет";
                    callbackMessage.Show();
                }
            }
        }

        private void btnUpdateCoach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxUpdateSubNum.Text, out int SubNumber) != false)
            {
                if (int.TryParse(TextBoxUpdateIDCoach.Text, out int NewIdCoach) != false)
                {
                    string ClientUpdate = clientlogic.Update(SubNumber, NewIdCoach);
                   
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = ClientUpdate;
                    callbackMessage.Show();
                }
                else
                {
                    CallBackForm callbackMessage = new CallBackForm();
                    callbackMessage.ErrorMessage = "Введен не корректный ID";
                    callbackMessage.Show();
                }
            }
            else
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Некорректно введен номер";
                callbackMessage.Show();
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAddIdCoach.Text, out int idcoach) != false)
            {
                Client Client = new Client()
                {
                    FirstName = textAddFirstNameClient.Text,
                    LastName = textBoxAddLastNameClient.Text,
                    MiddleName = textBoxAddMiddleNameClient.Text,
                    IDCoach = idcoach
                };

                string AddClient = clientlogic.Add(Client);
                var ClientGetDataBase = clientlogic.GetAll();
                _gridClient(ClientGetDataBase);

                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = AddClient;
                callbackMessage.Show();
            }
            else 
            {
                CallBackForm callbackMessage = new CallBackForm();
                callbackMessage.ErrorMessage = "Введен не корректный ID";
                callbackMessage.Show();
            } 
        }
    }
}
