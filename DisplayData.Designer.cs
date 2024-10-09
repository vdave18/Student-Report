namespace Make_Up_Project
{
    partial class DisplayData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label student_Number_Label;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label quiz_MArks_Label;
            System.Windows.Forms.Label lab_Test_Marks_Label;
            System.Windows.Forms.Label lecture_Test_Marks_Label;
            System.Windows.Forms.Label research_Project_MarksLabel;
            System.Windows.Forms.Label final_Project_Marks_Label;
            System.Windows.Forms.Label average_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayData));
            this.studentsDataSet = new Make_Up_Project.StudentsDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Make_Up_Project.StudentsDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new Make_Up_Project.StudentsDataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.student_Number_TextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.quiz_MArks_TextBox = new System.Windows.Forms.TextBox();
            this.lab_Test_Marks_TextBox = new System.Windows.Forms.TextBox();
            this.lecture_Test_Marks_TextBox = new System.Windows.Forms.TextBox();
            this.research_Project_MarksTextBox = new System.Windows.Forms.TextBox();
            this.final_Project_Marks_TextBox = new System.Windows.Forms.TextBox();
            this.average_TextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            student_Number_Label = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            quiz_MArks_Label = new System.Windows.Forms.Label();
            lab_Test_Marks_Label = new System.Windows.Forms.Label();
            lecture_Test_Marks_Label = new System.Windows.Forms.Label();
            research_Project_MarksLabel = new System.Windows.Forms.Label();
            final_Project_Marks_Label = new System.Windows.Forms.Label();
            average_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Make_Up_Project.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // student_Number_Label
            // 
            student_Number_Label.AutoSize = true;
            student_Number_Label.Location = new System.Drawing.Point(22, 72);
            student_Number_Label.Name = "student_Number_Label";
            student_Number_Label.Size = new System.Drawing.Size(109, 16);
            student_Number_Label.TabIndex = 1;
            student_Number_Label.Text = "Student Number :";
            // 
            // student_Number_TextBox
            // 
            this.student_Number_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Student Number ", true));
            this.student_Number_TextBox.Location = new System.Drawing.Point(182, 69);
            this.student_Number_TextBox.Name = "student_Number_TextBox";
            this.student_Number_TextBox.Size = new System.Drawing.Size(100, 22);
            this.student_Number_TextBox.TabIndex = 2;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(22, 100);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(75, 16);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(182, 97);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(22, 128);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(75, 16);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(182, 125);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // quiz_MArks_Label
            // 
            quiz_MArks_Label.AutoSize = true;
            quiz_MArks_Label.Location = new System.Drawing.Point(22, 156);
            quiz_MArks_Label.Name = "quiz_MArks_Label";
            quiz_MArks_Label.Size = new System.Drawing.Size(80, 16);
            quiz_MArks_Label.TabIndex = 7;
            quiz_MArks_Label.Text = "Quiz MArks :";
            // 
            // quiz_MArks_TextBox
            // 
            this.quiz_MArks_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Quiz MArks ", true));
            this.quiz_MArks_TextBox.Location = new System.Drawing.Point(182, 153);
            this.quiz_MArks_TextBox.Name = "quiz_MArks_TextBox";
            this.quiz_MArks_TextBox.Size = new System.Drawing.Size(100, 22);
            this.quiz_MArks_TextBox.TabIndex = 8;
            // 
            // lab_Test_Marks_Label
            // 
            lab_Test_Marks_Label.AutoSize = true;
            lab_Test_Marks_Label.Location = new System.Drawing.Point(22, 184);
            lab_Test_Marks_Label.Name = "lab_Test_Marks_Label";
            lab_Test_Marks_Label.Size = new System.Drawing.Size(106, 16);
            lab_Test_Marks_Label.TabIndex = 9;
            lab_Test_Marks_Label.Text = "Lab Test Marks :";
            // 
            // lab_Test_Marks_TextBox
            // 
            this.lab_Test_Marks_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Lab Test Marks ", true));
            this.lab_Test_Marks_TextBox.Location = new System.Drawing.Point(182, 181);
            this.lab_Test_Marks_TextBox.Name = "lab_Test_Marks_TextBox";
            this.lab_Test_Marks_TextBox.Size = new System.Drawing.Size(100, 22);
            this.lab_Test_Marks_TextBox.TabIndex = 10;
            // 
            // lecture_Test_Marks_Label
            // 
            lecture_Test_Marks_Label.AutoSize = true;
            lecture_Test_Marks_Label.Location = new System.Drawing.Point(22, 212);
            lecture_Test_Marks_Label.Name = "lecture_Test_Marks_Label";
            lecture_Test_Marks_Label.Size = new System.Drawing.Size(127, 16);
            lecture_Test_Marks_Label.TabIndex = 11;
            lecture_Test_Marks_Label.Text = "Lecture Test Marks :";
            // 
            // lecture_Test_Marks_TextBox
            // 
            this.lecture_Test_Marks_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Lecture Test Marks ", true));
            this.lecture_Test_Marks_TextBox.Location = new System.Drawing.Point(182, 209);
            this.lecture_Test_Marks_TextBox.Name = "lecture_Test_Marks_TextBox";
            this.lecture_Test_Marks_TextBox.Size = new System.Drawing.Size(100, 22);
            this.lecture_Test_Marks_TextBox.TabIndex = 12;
            // 
            // research_Project_MarksLabel
            // 
            research_Project_MarksLabel.AutoSize = true;
            research_Project_MarksLabel.Location = new System.Drawing.Point(22, 240);
            research_Project_MarksLabel.Name = "research_Project_MarksLabel";
            research_Project_MarksLabel.Size = new System.Drawing.Size(154, 16);
            research_Project_MarksLabel.TabIndex = 13;
            research_Project_MarksLabel.Text = "Research Project Marks:";
            // 
            // research_Project_MarksTextBox
            // 
            this.research_Project_MarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Research Project Marks", true));
            this.research_Project_MarksTextBox.Location = new System.Drawing.Point(182, 237);
            this.research_Project_MarksTextBox.Name = "research_Project_MarksTextBox";
            this.research_Project_MarksTextBox.Size = new System.Drawing.Size(100, 22);
            this.research_Project_MarksTextBox.TabIndex = 14;
            // 
            // final_Project_Marks_Label
            // 
            final_Project_Marks_Label.AutoSize = true;
            final_Project_Marks_Label.Location = new System.Drawing.Point(22, 268);
            final_Project_Marks_Label.Name = "final_Project_Marks_Label";
            final_Project_Marks_Label.Size = new System.Drawing.Size(127, 16);
            final_Project_Marks_Label.TabIndex = 15;
            final_Project_Marks_Label.Text = "Final Project Marks :";
            // 
            // final_Project_Marks_TextBox
            // 
            this.final_Project_Marks_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Final Project Marks ", true));
            this.final_Project_Marks_TextBox.Location = new System.Drawing.Point(182, 265);
            this.final_Project_Marks_TextBox.Name = "final_Project_Marks_TextBox";
            this.final_Project_Marks_TextBox.Size = new System.Drawing.Size(100, 22);
            this.final_Project_Marks_TextBox.TabIndex = 16;
            // 
            // average_Label
            // 
            average_Label.AutoSize = true;
            average_Label.Location = new System.Drawing.Point(22, 296);
            average_Label.Name = "average_Label";
            average_Label.Size = new System.Drawing.Size(65, 16);
            average_Label.TabIndex = 17;
            average_Label.Text = "Average :";
            // 
            // average_TextBox
            // 
            this.average_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Average ", true));
            this.average_TextBox.Location = new System.Drawing.Point(182, 293);
            this.average_TextBox.Name = "average_TextBox";
            this.average_TextBox.Size = new System.Drawing.Size(100, 22);
            this.average_TextBox.TabIndex = 18;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.studentsBindingSource;
            this.listBox1.DisplayMember = "Student Number ";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(390, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 84);
            this.listBox1.TabIndex = 19;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.studentsDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quiz Marks ",
            "Lab Test ",
            "Lecture Test",
            "Research Project",
            "Final Project"});
            this.comboBox1.Location = new System.Drawing.Point(390, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "> 80",
            "< 50",
            "60 - 70"});
            this.comboBox2.Location = new System.Drawing.Point(563, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.studentsDataSet;
            // 
            // studentsBindingSource3
            // 
            this.studentsBindingSource3.DataMember = "Students";
            this.studentsBindingSource3.DataSource = this.studentsDataSet;
            // 
            // studentsBindingSource4
            // 
            this.studentsBindingSource4.DataMember = "Students";
            this.studentsBindingSource4.DataSource = this.studentsDataSet;
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(student_Number_Label);
            this.Controls.Add(this.student_Number_TextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(quiz_MArks_Label);
            this.Controls.Add(this.quiz_MArks_TextBox);
            this.Controls.Add(lab_Test_Marks_Label);
            this.Controls.Add(this.lab_Test_Marks_TextBox);
            this.Controls.Add(lecture_Test_Marks_Label);
            this.Controls.Add(this.lecture_Test_Marks_TextBox);
            this.Controls.Add(research_Project_MarksLabel);
            this.Controls.Add(this.research_Project_MarksTextBox);
            this.Controls.Add(final_Project_Marks_Label);
            this.Controls.Add(this.final_Project_Marks_TextBox);
            this.Controls.Add(average_Label);
            this.Controls.Add(this.average_TextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Name = "DisplayData";
            this.Text = "DisplayData";
            this.Load += new System.EventHandler(this.DisplayData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_Number_TextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox quiz_MArks_TextBox;
        private System.Windows.Forms.TextBox lab_Test_Marks_TextBox;
        private System.Windows.Forms.TextBox lecture_Test_Marks_TextBox;
        private System.Windows.Forms.TextBox research_Project_MarksTextBox;
        private System.Windows.Forms.TextBox final_Project_Marks_TextBox;
        private System.Windows.Forms.TextBox average_TextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource studentsBindingSource3;
        private System.Windows.Forms.BindingSource studentsBindingSource4;
    }
}