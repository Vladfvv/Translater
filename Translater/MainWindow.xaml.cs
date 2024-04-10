using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Translater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 12.Создать строку состояния и в нее выводить номер учебной группы
    ///слушателя.Если ФИО разработчика начинается на гласную букву русского
    ///алфавита, то заменить каждый нечетный символ в номере группы на
    ///символ нуль;
    public partial class MainWindow : Window
    {
        string s = "";
        string s2 = "";
        bool testFio = false;
        bool testFio2 = false;
        char[] vowels = { 'А', 'О', 'Э', 'Ю', 'И', 'Я', 'Ы', 'У', 'Й', 'Е', 'Ё' };
        string newStr = "";
        string newStr2 = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            s = (string)fio.Content;           
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    foreach (char c in vowels)
                    {
                        if (s[i] == c)
                        {
                            testFio = true;
                            break;
                        }
                    }
                }
            }
            if (testFio == true)
            {
                string strGroup = (string)myGroup.Content;
                newStr += strGroup[0];
                for (int j = 1; j < strGroup.Length; j++)
                {
                    if ((j < 8) && (j % 2 != 0)) newStr += '0';
                    else newStr += strGroup[j];
                }
                myGroup.Content = newStr.ToString();
            }

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            s2 = (string)fio2.Content;           
            for (int i = 0; i < s2.Length; i++)
            {
                if (Char.IsUpper(s2[i]))
                {
                    foreach (char c in vowels)
                    {
                        if (s2[i] == c)
                        {
                            testFio2 = true;
                            break;
                        }
                    }
                }
            }
            if (testFio2 == true)
            {
                string strGroup2 = (string)myGroup2.Content;
                newStr2 += strGroup2[0];
                for (int j = 1; j < strGroup2.Length; j++)
                {
                    if ((j < 8) && (j % 2 != 0)) newStr2 += '0';
                    else newStr2 += strGroup2[j];
                }
                myGroup2.Content = newStr2.ToString();
            }
        }
    }
}