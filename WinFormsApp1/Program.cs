using System;
using System.Windows.Forms;

namespace StudentPerformanceApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Включает визуальные стили для приложения
            Application.EnableVisualStyles();

            // Устанавливает совместимость с текстовым рендерингом
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускает главную форму приложения (Form1)
            Application.Run(new Form1());
        }
    }
}