详细的读取信息操作参考：
public IActionResult TransDataToPageFirst(string id)
        {
            string themevalue = id;
            List<double> valuelist = new List<double>();
            List<string> datelist = new List<string>();
            string path = "D:/ZYAPPXmlData/BackData/"+ themevalue + ".xml";
            //TODO:查询XML中的数据返回给界面
            XElement root = XElement.Load(path);
            IEnumerable<XElement> vnodes = from vnode in root.Descendants("Data")
                                               select vnode;
            IEnumerable<XElement> dnodes = from dnode in root.Descendants("Data")
                                               select dnode;
            foreach (XElement vnode in vnodes)
            {
                valuelist.Add(Convert.ToDouble(vnode.Element("Value").Value));
            }
                        
            foreach (XElement dnode in dnodes)
            {
                datelist.Add(Convert.ToDateTime(dnode.Element("Date").Value).Year.ToString());
            }

            double[] valuearr = valuelist.ToArray();
            string[] datearr = datelist.ToArray();
            return View();
        }       