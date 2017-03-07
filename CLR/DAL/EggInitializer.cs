using CLR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.DAL
{
    public class EggInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<EggContext>
    {
        protected override void Seed(EggContext context)
        {
            var technologies = new List<Technology>()
            {
                new Technology()
                {
                Name = "ECMAScript",
                Image = "~/technologies/ecmascript/ecmascript.jpeg",
                LargeImage = "~/technologies/ecmascript/ecmascript-lg.jpeg",
                MediumImage = "~/technologies/ecmascript/ecmascript-md.jpeg",
                Intro = "Hello hihi hiha",
                LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                },
                new Technology()
                {
                Name = ".NET Framwork",
                Image = "~/technologies/netframework/netframework.jpeg",
                LargeImage = "~/technologies/netframework/netframework-lg.jpeg",
                MediumImage = "~/technologies/netframework/netframework-md.jpeg",
                Intro = "Hello hihi hiha",
                LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                },
                new Technology()
                {
                Name = "Spring",
                Image = "~/technologies/spring/spring.jpeg",
                LargeImage = "~/technologies/spring/spring-lg.jpeg",
                MediumImage = "~/technologies/spring/spring-md.jpeg",
                Intro = "Hello hihi hiha",
                LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                },
                new Technology()
                {
                Name = "Django",
                Image = "~/technologies/django/django.jpeg",
                LargeImage = "~/technologies/django/django-lg.jpeg",
                MediumImage = "~/technologies/django/django-md.jpeg",
                Intro = "Hello hihi hiha",
                LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                },
                new Technology()
                {
                Name = "Nodejs",
                Image = "~/technologies/nodejs/nodejs.jpeg",
                LargeImage = "~/technologies/nodejs/nodejs-lg.jpeg",
                MediumImage = "~/technologies/nodejs/nodejs-md.jpeg",
                Intro = "Hello hihi hiha",
                LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                }
            };

            foreach(Technology tc in technologies)
            {
                context.Technologies.Add(tc);
            }

            var instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    Iid = "adswdds",
                    FirstName = "dsfsd",
                    LastName = "dshnfds",
                    Google = "gerjshds",
                    Twitter = "duhfuids",
                    Facebook = "fb_yd73",
                    Blog = "dslkfnlksdfsd",
                    Intro = "sadlbfasjdnfkasdnflkasdnfasd",
                    Email = "dasfn@jbed.com",
                    Passwd = "123456",
                    Phone ="236492364823",
                    Address = "dnfjabnldkn9weqhdwendasd",
                    Avatar = "98243823740938423",
                    LargeAvatar = "98243823740938423",
                    MediumAvatar ="98243823740938423",
                    LastUpdate = BitConverter.GetBytes(DateTime.Now.Ticks)
                }
            };

            base.Seed(context);
        }
    }
}