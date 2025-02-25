using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentPerformanceApp
{
    public partial class Form1 : Form
    {
        private Student[] students;

        public Form1()
        {
            InitializeComponent();
            InitializeStudents();
            DisplayStudents();
        }

        private void InitializeStudents()
        {
            students = new Student[]
            {
                new Student("������", "����", "��������", "������ 1", new int[] { 4, 5, 4, 5, 4 }),
                new Student("������", "����", "��������", "������ 2", new int[] { 5, 5, 5, 5, 5 }),
                new Student("�������", "�����", "���������", "������ 1", new int[] { 3, 4, 4, 5, 4 }),
                new Student("��������", "�������", "����������", "������ 3", new int[] { 4, 4, 4, 4, 4 }),
                new Student("��������", "�����", "��������", "������ 2", new int[] { 5, 5, 4, 5, 5 }),
                new Student("��������", "�������", "����������", "������ 3", new int[] { 3, 3, 4, 3, 4 }),
                new Student("���������", "����", "��������", "������ 1", new int[] { 5, 5, 5, 5, 5 })
            };
        }

        private void DisplayStudents()
        {
            studentsDataGridView.DataSource = students.Select(s => new
            {
                ������� = s.LastName,
                ��� = s.FirstName,
                �������� = s.MiddleName,
                ������ = s.GroupNumber,
                ����������� = s.CalculateAverageGrade()
            }).ToList();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            var sortedStudents = students.OrderBy(s => s.CalculateAverageGrade()).ToArray();
            studentsDataGridView.DataSource = sortedStudents.Select(s => new
            {
                ������� = s.LastName,
                ��� = s.FirstName,
                �������� = s.MiddleName,
                ������ = s.GroupNumber,
                ����������� = s.CalculateAverageGrade()
            }).ToList();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var filteredStudents = students.Where(s => s.HasOnlyGoodGrades()).ToArray();
            studentsDataGridView.DataSource = filteredStudents.Select(s => new
            {
                ������� = s.LastName,
                ��� = s.FirstName,
                �������� = s.MiddleName,
                ������ = s.GroupNumber,
                ����������� = s.CalculateAverageGrade()
            }).ToList();
        }
    }
}