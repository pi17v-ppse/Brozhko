using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_example_Grishenko
{

	/**
	 * Пользователь
	 *
	 * Класс описывает информацию 
	 * о пользователе приложения. 
	 * 
	 * @author      BrozhkoDima
	 * @version     1.0.0
	 * @copyright   GNU Public License 
	 * @todo        Добавить больше информации о пользователе 
	 */
	public class user
	{
		/** 
		 * Имя пользователя 
		 * 
		 * Представляет собой имя пользователя 
		 * 
		 * @var   string name 
		 */
		string name;
		/** 
		 * Уникальный идентификатор пользователя 
		 * 
		 * Идентификатор пользователя 
		 * для работы в базе данных
		 * 
		 * @var   int id
		 */
		int id;
		/** 
		 * Все данные пользователя 
		 * 
		 * Список данных о пользователе,
		 * например, номер банковской карты,
		 * номер телефона, дата оформления карты
		 * и т.д. 
		 * 
		 * @var    List<string> user_info
		 */
		List<string> user_info;


		/** 
		 * Работа со свойством {@link name} 
		 * 
		 * Задается новое имя пользователя 
		 * 
		 * @param   string   new_name  Новое имя пользователя 
		 * @return  string   name      Возвращает новое имя 
		 */
		public string rename(string new_name)
		{
			name = new_name;
			return name;
		}

	}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private test_func1()
        {
        	strins s = "ssss";
        }

        // refresh informations about money operations
        public refresh222()
        {
        	for (int i = 0; i < 10; i ++)
        	{
	        	for (int j = 0; j < 10; j ++)
		        {
		        	for (int u = 0; u < 10; u ++)
		        	{
		        		table.add(database[i*j-u]);
		        	}
	        	}
        	}
        }

        // add new money operations
        public add()
        {
        	table.add(id, summ, date);
        }


        public new_function3_2()
        {
        	algorithm.new(34);
        }

        // sorting operations
        public sort()
        {
        	table.sort;
        }

    }
}
