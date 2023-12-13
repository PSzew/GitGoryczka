using System;
using System.Collections.Generic;
using System.Text;

namespace GitGoryczka.ClassModel
{
    public class UserClass
    {
        public UserClass(string @class, string path)
        {
            Class = @class;
            Path = path;
        }
        public UserClass()
        {

        }

        public string Class { get; set; }
        public string Path { get; set; }
    }
}
