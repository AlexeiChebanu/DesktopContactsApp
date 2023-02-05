﻿using DesktopContactsApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class ConsoleManagerWindow : Window
    {
        Contact contact;
        public ConsoleManagerWindow(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;

            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phoneNumberTextBox.Text = contact.Phone;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = nameTextBox.Text; 
            contact.Email = emailTextBox.Text;
            contact.Phone = phoneNumberTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }

            Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }

            Close();
        }
    }
}
