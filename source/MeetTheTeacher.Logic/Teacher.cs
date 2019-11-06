using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltet einen Eintrag in der Sprechstundentabelle
    /// Basisklasse für TeacherWithDetail
    /// </summary>
    public class Teacher : IComparable
    {
        public string _name;
        public string _day;
        public string _unit;
        public string _time;
        public string _room;
        public string _remark;

        public Teacher(string name,string day,string unit,string time,string room,string remark)
        {
            _name = name;
            _day = day;
            _unit = unit;
            _time = time;
            _room = room;
            _remark = remark;
        }

        public virtual string GetTeacherHtmlRow()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<tr>");
            sb.AppendLine($"<th align=\"center\">{GetHtmlForName()}</th>");
            sb.AppendLine($"<th align=\"center\">{_day}</th>");
            sb.AppendLine($"<th align=\"center\">{_time}</th>");
            sb.AppendLine($"<th align=\"center\">{_room}</th>");
            sb.AppendLine($"</tr>");
            sb.AppendLine();

            return sb.ToString();
        }

        public virtual string GetHtmlForName()
        {
            return _name;
        }

        public int CompareTo(object obj)
        {
            var teacher = obj as Teacher;
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            return _name.CompareTo(teacher._name);
        }

        public override string ToString()
        {
            return $"{nameof(_name)}:{_name}, {nameof(_day)}:{_day}, {nameof(_time)}:{_time}, " + 
                 $"{nameof(_room)}:{_room}, {nameof(_remark)}:{_remark}";
        }
    }
}
