﻿using BusinessTier;
using DataTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class EventForm : Form
    {
        private readonly Form mainForm;
        public EventForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            EventController eventController = new EventController();
            eventFormGridView.DataSource = eventController.GetEvents();
        }

        private void EventDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var selectedEvent = (Event)eventFormGridView.CurrentRow.DataBoundItem;
            new ManageEventForm(this, selectedEvent).Show();
            this.Hide();
        }

        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void EventFormGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                eventFormGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("Financial request", FinancialRequestItem_Click));

                var relativeMousePosition = eventFormGridView.PointToClient(Cursor.Position);
                cm.Show(eventFormGridView, relativeMousePosition);
            }
        }

        private void FinancialRequestItem_Click(object sender, EventArgs e)
        {
            var selectedEvent = (Event)eventFormGridView.CurrentRow.DataBoundItem;
            new ManageFinancialRequestForm(this, selectedEvent).Show();
            this.Hide();
        }
    }
}
