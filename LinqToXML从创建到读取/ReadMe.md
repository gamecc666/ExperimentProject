��ϸ�Ķ�ȡ��Ϣ�����ο���
public IActionResult TableSelectEvent(string tablename)
        {
            Dictionary<string, string> valueDic = new Dictionary<string, string>();
            string path = @"D:\ZYAPPXmlData\BackData";
            if (string.Compare(tablename, "���¶Գ��ʰ뵺��Ӱ��")==0) {
                XElement Root = XElement.Load(path);
                IEnumerable<XElement> childNodes = from data in Root.Element("ThemeData").Elements()
                                                   select data;
                foreach(XElement node in childNodes)
                {
                    Console.WriteLine("���֣�" + node.Name + " ||ֵ��" + node.Value);

                }
            };
            return View();
        }