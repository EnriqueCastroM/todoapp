namespace todoapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTareas = new Label();
            listBoxTareas = new ListBox();
            labelNuevaTarea = new Label();
            textBoxNuevaTarea = new TextBox();
            buttonAgregarTarea = new Button();
            buttonEliminarTarea = new Button();
            buttonExportarTareas = new Button();
            labelFechaVencimiento = new Label();
            dateTimePickerVencimiento = new DateTimePicker();
            checkBoxCompletada = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTareas
            // 
            labelTareas.AutoSize = true;
            labelTareas.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTareas.Location = new Point(13, 192);
            labelTareas.Name = "labelTareas";
            labelTareas.Size = new Size(139, 25);
            labelTareas.TabIndex = 0;
            labelTareas.Text = "Tareas pendientes";
            labelTareas.Click += labelTareas_Click;
            // 
            // listBoxTareas
            // 
            listBoxTareas.BackColor = SystemColors.InactiveCaption;
            listBoxTareas.FormattingEnabled = true;
            listBoxTareas.ItemHeight = 15;
            listBoxTareas.Location = new Point(13, 222);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(460, 214);
            listBoxTareas.TabIndex = 1;
            listBoxTareas.SelectedIndexChanged += listBoxTareas_SelectedIndexChanged;
            // 
            // labelNuevaTarea
            // 
            labelNuevaTarea.AutoSize = true;
            labelNuevaTarea.Location = new Point(15, 52);
            labelNuevaTarea.Name = "labelNuevaTarea";
            labelNuevaTarea.Size = new Size(70, 15);
            labelNuevaTarea.TabIndex = 2;
            labelNuevaTarea.Text = "Nueva tarea";
            // 
            // textBoxNuevaTarea
            // 
            textBoxNuevaTarea.Location = new Point(13, 69);
            textBoxNuevaTarea.Name = "textBoxNuevaTarea";
            textBoxNuevaTarea.Size = new Size(237, 23);
            textBoxNuevaTarea.TabIndex = 3;
            // 
            // buttonAgregarTarea
            // 
            buttonAgregarTarea.Location = new Point(13, 167);
            buttonAgregarTarea.Name = "buttonAgregarTarea";
            buttonAgregarTarea.Size = new Size(100, 23);
            buttonAgregarTarea.TabIndex = 4;
            buttonAgregarTarea.Text = "Agregar tarea";
            buttonAgregarTarea.UseVisualStyleBackColor = true;
            buttonAgregarTarea.Click += buttonAgregarTarea_Click;
            // 
            // buttonEliminarTarea
            // 
            buttonEliminarTarea.Location = new Point(13, 442);
            buttonEliminarTarea.Name = "buttonEliminarTarea";
            buttonEliminarTarea.Size = new Size(100, 23);
            buttonEliminarTarea.TabIndex = 5;
            buttonEliminarTarea.Text = "Eliminar tarea";
            buttonEliminarTarea.UseVisualStyleBackColor = true;
            buttonEliminarTarea.Click += buttonEliminarTarea_Click;
            // 
            // buttonExportarTareas
            // 
            buttonExportarTareas.Location = new Point(373, 442);
            buttonExportarTareas.Name = "buttonExportarTareas";
            buttonExportarTareas.Size = new Size(100, 23);
            buttonExportarTareas.TabIndex = 6;
            buttonExportarTareas.Text = "Exportar tareas";
            buttonExportarTareas.UseVisualStyleBackColor = true;
            buttonExportarTareas.Click += buttonExportarTareas_Click;
            // 
            // labelFechaVencimiento
            // 
            labelFechaVencimiento.AutoSize = true;
            labelFechaVencimiento.Location = new Point(13, 95);
            labelFechaVencimiento.Name = "labelFechaVencimiento";
            labelFechaVencimiento.Size = new Size(123, 15);
            labelFechaVencimiento.TabIndex = 7;
            labelFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // dateTimePickerVencimiento
            // 
            dateTimePickerVencimiento.Location = new Point(13, 114);
            dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            dateTimePickerVencimiento.Size = new Size(237, 23);
            dateTimePickerVencimiento.TabIndex = 8;
            // 
            // checkBoxCompletada
            // 
            checkBoxCompletada.AutoSize = true;
            checkBoxCompletada.Location = new Point(13, 142);
            checkBoxCompletada.Name = "checkBoxCompletada";
            checkBoxCompletada.Size = new Size(119, 19);
            checkBoxCompletada.TabIndex = 9;
            checkBoxCompletada.Text = "Tarea completada";
            checkBoxCompletada.UseVisualStyleBackColor = true;
            checkBoxCompletada.CheckedChanged += checkBoxCompletada_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(474, 32);
            label1.TabIndex = 10;
            label1.Text = "Aplicación de Lista de Tareas Pendientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(502, 544);
            Controls.Add(label1);
            Controls.Add(checkBoxCompletada);
            Controls.Add(dateTimePickerVencimiento);
            Controls.Add(labelFechaVencimiento);
            Controls.Add(buttonExportarTareas);
            Controls.Add(buttonEliminarTarea);
            Controls.Add(buttonAgregarTarea);
            Controls.Add(textBoxNuevaTarea);
            Controls.Add(labelNuevaTarea);
            Controls.Add(listBoxTareas);
            Controls.Add(labelTareas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTareas;
        private ListBox listBoxTareas;
        private Label labelNuevaTarea;
        private TextBox textBoxNuevaTarea;
        private Button buttonAgregarTarea;
        private Button buttonEliminarTarea;
        private Button buttonExportarTareas;
        private Label labelFechaVencimiento;
        private DateTimePicker dateTimePickerVencimiento;
        private CheckBox checkBoxCompletada;
        private Label label1;
    }
}