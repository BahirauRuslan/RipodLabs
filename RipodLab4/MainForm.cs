using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RipodLab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.TasksTrackBar_Scroll(this, null);
        }

        private void SetSizeToMatrixGridView(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }

            this.matrixGridView.ColumnCount = size;
            this.matrixGridView.RowCount = size;
        }

        private void SetSizeToOperationsTimeGridView(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }

            this.operationTimeGridView.RowCount = size;
        }

        private void FillOperationTimeGridView(string fillTime)
        {
            for (var i = 0; i < this.matrixGridView.ColumnCount; i++)
            {
                this.operationTimeGridView[0, i].Value = i + 1;
                this.operationTimeGridView[1, i].Value = fillTime;
            }
        }

        private void FillMatrixGridView(string fillMark)
        {
            for (var i = 0; i < this.matrixGridView.RowCount; i++)
            {
                for (var j = 0; j < this.matrixGridView.ColumnCount; j++)
                {
                    this.matrixGridView[j, i].Value = fillMark;
                }
            }
        }

        private void FillResultGridView(Plan plan)
        {
            int number = 0;
            this.resultGridView.RowCount = plan.GetSteps().Count;
            foreach (var step in plan.GetSteps())
            {
                this.resultGridView[0, number].Value = (number + 1).ToString();
                this.resultGridView[1, number].Value = this.TasksInStep(step);
                this.resultGridView[2, number].Value = plan.GetCountType(number, "+");
                this.resultGridView[3, number].Value = plan.GetCountType(number++, "*");
            }
        }

        private string TasksInStep(IList<Node> step)
        {
            var builder = new StringBuilder();

            foreach (Node node in step)
            {
                builder.Append($"{ node.Value }{ node.Type }");
                builder.Append(" ");
            }

            return builder.ToString();
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            int.TryParse(addTextBox.Text, out int add);
            int.TryParse(mulTextBox.Text, out int mul);
            double.TryParse(timeStepTextBox.Text, out double timeStep);
            var graph = new GraphConstructor().ConstructGraph(this.matrixGridView, this.typeTextBox.Text, this.operationTimeGridView);
            var plan = new Plan(graph, add, mul, timeStep);
            this.FillResultGridView(plan);
        }

        private void TasksTrackBar_Scroll(object sender, EventArgs e)
        {
            this.taskLabel.Text = this.tasksTrackBar.Value.ToString();
            this.typeTextBox.MaxLength = this.tasksTrackBar.Value;
            this.SetSizeToMatrixGridView(this.tasksTrackBar.Value);
            this.SetSizeToOperationsTimeGridView(this.tasksTrackBar.Value);
            this.FillOperationTimeGridView("1,00");
            this.FillMatrixGridView("0");
        }
    }
}
