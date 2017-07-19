﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MI_QuestionManager_Click(object sender, EventArgs e)
        {
            var questions = new F_Questions();
            questions.ShowDialog();
        }

        private void B_StartExam_Click(object sender, EventArgs e)
        {
            F_Exam examForm = new F_Exam();
            examForm.ShowDialog();
        }

        private void MI_Categories_Click(object sender, EventArgs e)
        {
            var categoriesForm = new F_Categories();
            categoriesForm.ShowDialog();
        }
    }
}
