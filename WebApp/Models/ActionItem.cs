using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ActionItem
    {
        public static string _name;
        public static int _age;
        public static string _sex;
        public static string _add;

        public ActionItem(string name, int age, string sex, string add)
        {
            _name = name;
            _age = age;
            _sex = sex;
            _add = add;
        }

        public ActionItem()
        {

        }

        [DisplayName("個人の名称")]       // 追記 ウェーブページに出ます。									

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        [DisplayName("個人の年齢")]       // 追記 ウェーブページに出ます。									

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        [DisplayName("個人の性別")]       // 追記 ウェーブページに出ます。									
        public string Sex {
            get
            {
                return  _sex;
            }
            set
            {
                _sex = value;
            }


        }
        [DisplayName("個人の住所")]       // 追記 ウェーブページに出ます。									
        public string Add
        {
            get
            {
                return  _add;
            }
            set
            {
                _add = value;
            }
        }
    }
}