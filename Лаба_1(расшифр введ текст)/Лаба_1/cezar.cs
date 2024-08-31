using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;
using System.Runtime.CompilerServices;



namespace Лаба_1
{
    public partial class cezar : Form
    {
        
        string eng_string1 = "abcdefghijklmnopqrstuvwxyz";
        string eng_string2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rus_string1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string rus_string2 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        //специальные строки для проверки вводимого текста
        string eng_string = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ\n\r ";
        string rus_string = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\r ";
        
        //интегрируем большое число для ключа
        BigInteger key;
        //используем общую для
        string Itog = "";
        public cezar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CezarProgram";
        }
        //
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //
        private void rus_CheckedChanged(object sender, EventArgs e)
        {
            if (rus.Checked == true) //проверка свойства (выбрана или нет)
            {
                eng.Checked = false; //меняем свойство другой кнопки 
                label3.Visible = false; //прячем текст об ошибке
                textBox1.Text = ""; //очистка поля
            }
        }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {
            if (eng.Checked == true)
            {
                rus.Checked = false; //меняем свойство другой кнопки 
                label3.Visible = false; //прячем текст об ошибке
                textBox1.Text = ""; //очистка поля
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical; //добавление вертикального скроллбара если текст больше поля
            string text = textBox1.Text; //вытаскиваем текст для проверки
            //проверка вводимого текста
            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                if (rus.Checked == true && !rus_string.Contains(text[i]))
                //не даем ввести все что не входит в контрольные строки
                {
                    label3.Visible = true;
                    textBox1.Text = text.Remove(text.Length - 1);
                }
                if (eng.Checked == true && !eng_string.Contains(text[i]))
                {
                    label3.Visible = true;
                    textBox1.Text = text.Remove(text.Length - 1);
                }

            }
            //переводим каретку в конец (точку старта ввода)
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string text = textBox3.Text; //извлекаем текст в поле ключа
            string numbers = "1234567890-"; //контрольная строка 
            for(int i = 0; i < textBox3.Text.Length; i++)
            {
                if (!numbers.Contains(text[i])) //проверка на вхождение в контрольную строку
                { 
                    label2.Visible = true;
                    textBox3.Text = text.Remove(text.IndexOf(text[i]));
                }
            }
            for (int i = 1; i < textBox3.Text.Length; i++) 
            {
                if (text[i] == '-') //нельзя ввести минус не в начало -> нельзя ввести больше одного раза
                {
                    textBox3.Text = text.Remove(i);
                }
            }
            if (text.Length > 1 && text[0] == '0' && numbers.Contains(text[1]))
            {
                textBox3.Text = text.Remove(1); //нельзя вписать число с нуля (т.е. 0 только один, и после него не может быть знаков)
            }
            if (text.Length > 1 && text[0] == '-'  && text[1] == '0') // нельзя вписать число -0
            {
                textBox3.Text = text.Remove(1);
            }
            //если совершены ошибки возвращаем каретку в конец строки
            textBox3.SelectionStart = textBox3.Text.Length;
            //присваиваем введеное число в ключ?
            if(textBox3.Text != "" && textBox3.Text != "-")
            {
                string key_string = textBox3.Text;
                key = BigInteger.Parse(key_string);
            }
           
        }


        private void shifr_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; //извлекаем текст
            if (eng.Checked == true && BigInteger.Abs(key) > 26) //если ключ больше алфавита, извлекаем ту часть, на какую нужно сместиться
            {
                key = key % 26;
            }
            if (rus.Checked == true && BigInteger.Abs(key) > 33)
            {
                key = key % 33;
            }
            if (textBox3.Text != "" && textBox1.Text != "") //если поля не пустые можно делать шифровку
            {
                for (int i = 0; i < text.Length; i++) //идем по тексту textBox1
                {
                    if (rus.Checked == true)
                    { //сдвиг соответствующих русских букв
                        if (rus_string1.Contains(text[i]) == true) //проверка на русс буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (rus_string1.IndexOf(text[i]) + (int)key < rus_string1.Length) //проверка на выход из массива
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) + (int)key - 33];
                                }
                            }
                            else
                            {
                                if (rus_string1.IndexOf(text[i]) + (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) + (int)key + 33];
                                }
                            }

                        }
                        else if (rus_string2.Contains(text[i]) == true) //проверка на русс буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (rus_string2.IndexOf(text[i]) + (int)key < rus_string2.Length) //проверка на выход из массива
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) + (int)key - 33];
                                }
                            }
                            else
                            {
                                if (rus_string2.IndexOf(text[i]) + (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) + (int)key + 33];
                                }
                            }
                        }
                        else
                        {
                            Itog += " ";
                        }
                    }
                    else //шифровка английского текста
                    {
                        if (eng_string1.Contains(text[i]) == true) //проверка на eng буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (eng_string1.IndexOf(text[i]) + (int)key < eng_string1.Length) //проверка на выход из массива
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) + (int)key - 26];
                                }
                            }
                            else
                            {
                                if (eng_string1.IndexOf(text[i]) + (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) + (int)key + 26];
                                }
                            }

                        }
                        else if (eng_string2.Contains(text[i]) == true) //проверка на eng буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (eng_string2.IndexOf(text[i]) + (int)key < eng_string2.Length) //проверка на выход из массива
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) + (int)key - 26];
                                }
                            }
                            else
                            {
                                if (eng_string2.IndexOf(text[i]) + (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) + (int)key];
                                }
                                else
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) + (int)key + 26];
                                }
                            }
                        }
                        else
                        {
                            Itog += " ";
                        }
                    }
                }

            }
            else //если поля пустые выводим ошибку
            {
                label5.Visible = true;
            }
            itog.Text = Itog; //помещаем зашифрованный текст в элемент itog (label)
            Itog = ""; //очищаем переменную для дальнейших операций
        }

        private void deshifr_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; //извлекаем текст
            if (eng.Checked == true && Math.Abs((int)key) > 26) //если ключ больше алфавита, извлекаем ту часть, на какую нужно сместиться
            {
                key = key % 26;
            }
            if (rus.Checked == true && Math.Abs((int)key) > 33)
            {
                key = key % 33;
            }
            if (textBox3.Text != "" && textBox1.Text != "") //если поля не пустые можно делать шифровку
            {
                for (int i = 0; i < text.Length; i++) //идем по тексту textBox1
                {
                    if (rus.Checked == true)
                    { //сдвиг соответствующих русских букв
                        if (rus_string1.Contains(text[i]) == true)
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (rus_string1.IndexOf(text[i]) - (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) - (int)key + 33];
                                }
                            }
                            else
                            {
                                if (rus_string1.IndexOf(text[i]) - (int)key < rus_string1.Length) //проверка на выход из массива
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {
                                    Itog += rus_string1[rus_string1.IndexOf(text[i]) - (int)key - 33];
                                }
                            }
                        }
                        else if (rus_string2.Contains(text[i]) == true) //проверка на русс буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (rus_string2.IndexOf(text[i]) - (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) - (int)key + 33];
                                }
                            }
                            else
                            {
                                if (rus_string2.IndexOf(text[i]) - (int)key < rus_string2.Length) //проверка на выход из массива
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {
                                    Itog += rus_string2[rus_string2.IndexOf(text[i]) - (int)key - 33];
                                }
                            }
                        }
                        else
                        {
                            Itog += " ";
                        }
                    }
                    else //шифровка английского текста
                    {
                        if (eng_string1.Contains(text[i]) == true) //проверка на eng буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (eng_string1.IndexOf(text[i]) - (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) - (int)key + 26];
                                }
                            }
                            else
                            {
                                if (eng_string1.IndexOf(text[i]) - (int)key < eng_string1.Length) //проверка на выход из массива
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {
                                    Itog += eng_string1[eng_string1.IndexOf(text[i]) - (int)key - 26];
                                }
                            }
                        }
                        else if (eng_string2.Contains(text[i]) == true) //проверка на eng буквы
                        {
                            if (key.Sign > 0)
                            { //проверка знака ключа
                                if (eng_string2.IndexOf(text[i]) - (int)key >= 0) //проверка на выход из массива
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {//если ключ сдвигает букву на область вне массива алфавита, то вычитаем длину и идем с начала
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) - (int)key + 26];
                                }
                            }
                            else
                            {
                                if (eng_string2.IndexOf(text[i]) - (int)key < eng_string2.Length) //проверка на выход из массива
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) - (int)key];
                                }
                                else
                                {
                                    Itog += eng_string2[eng_string2.IndexOf(text[i]) - (int)key - 26];
                                }
                            }
                        }
                        else
                        {
                            Itog += " ";
                        }
                    }
                }

            }
            else //если поля пустые выводим ошибку
            {
                label5.Visible = true;
            }
            itog.Text = Itog; //помещаем зашифрованный текст в элемент itog (label)
            Itog = ""; //очищаем переменную с текстом
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void itog_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
