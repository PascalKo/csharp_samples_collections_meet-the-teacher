﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Klasse, die einen Detaileintrag mit Link auf dem Namen realisiert.
    /// </summary>
    public class TeacherWithDetail : Teacher
    {
        public int _id;

        public TeacherWithDetail(string name, string day, string room, string time, string remark,int id)
            :base(name,day,room,time,remark)
        {
            _id = id;
        }

        public override string GetHtmlForName()
        {
            return $"<a href=\"?id={_id}\">{base.GetHtmlForName()}</a>";
        }

        public override string ToString()
        {
            return base.ToString() + $" {nameof(_id)}:{_id}";
        }
    }
}
