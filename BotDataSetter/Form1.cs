﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComanJuiceBusinessCommunicator;

namespace BotDataSetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            BotMessageData data = SerializationUtilities.LoadData();
            if (data.RendomMessages != null)
                RendomMessages = data.RendomMessages.ToList();
            else
                RendomMessages= new List<string>();

            MessagesListToTreeView();
            textBoxFirstMessage.Text = data.FirstMessage;
        }

        public List<string> RendomMessages;
        private void buttonAddText_Click(object sender, EventArgs e)
        {
            if(RendomMessages==null)
                RendomMessages=new List<string>();
            if (rendomMessageTextBox.Text == "")
                return;
            RendomMessages.Add(rendomMessageTextBox.Text);
            MessagesListToTreeView();
            rendomMessageTextBox.Text = "";
        }

        private void MessagesListToTreeView()
        {
            treeViewReanomMessages.Nodes.Clear();
            for (int i = 0; i < RendomMessages.Count; i++)
            {
                treeViewReanomMessages.Nodes.Add($"{i}. {RendomMessages[i]}", RendomMessages[i]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (RendomMessages == null)
                new ArgumentException();
               
            SerializationUtilities.SaveData(new BotMessageData(textBoxFirstMessage.Text,RendomMessages.ToArray()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode treeNoe = treeViewReanomMessages.SelectedNode;
            if (treeNoe == null)
            {
                MessageBox.Show("Please Select node to remove");
                return;
            }
            RendomMessages.Remove(treeNoe.Text);
            MessagesListToTreeView();
        }

        private void TreeViewDoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNoe = treeViewReanomMessages.SelectedNode;
            if (treeNoe == null)
            {
                MessageBox.Show("Please Select node to remove");
                return;
            }
            rendomMessageTextBox.Text = treeNoe.Text;

        }
    }
}
