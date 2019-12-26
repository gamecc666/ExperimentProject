详细的读取信息操作参考：
public IActionResult TableSelectEvent(string tablename)
        {
            Dictionary<string, string> valueDic = new Dictionary<string, string>();
            string path = @"D:\ZYAPPXmlData\BackData";
            if (string.Compare(tablename, "萨德对朝鲜半岛的影响")==0) {
                XElement Root = XElement.Load(path);
                IEnumerable<XElement> childNodes = from data in Root.Element("ThemeData").Elements()
                                                   select data;
                foreach(XElement node in childNodes)
                {
                    Console.WriteLine("名字：" + node.Name + " ||值：" + node.Value);

                }
            };
            return View();
        }