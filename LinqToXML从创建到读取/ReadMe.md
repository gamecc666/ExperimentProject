��ϸ�Ķ�ȡ��Ϣ�����ο���
public IActionResult TableSelectEvent(string id)
{
	string tablename = id;
	List<string> valueList = new List<string>();
	string path = @"D:\ZYAPPXmlData\BackData\���¶Գ��ʰ뵺��Ӱ��.xml";
	if (string.Compare(tablename, "����ʱ��Ա�ͼ")==0) {
		XElement Root = XElement.Load(path);
		IEnumerable<XElement> childNodes = from data in Root.Descendants("Data").Elements()
										   select data;
		foreach(XElement node in childNodes)
		{
			Console.WriteLine("���֣�" + node.Name + " ||ֵ��" + node.Value);
			valueList.Add(node.Value);
		}
	};
	return View("~/Views/MainContent/ScenarioExcuteEvent.cshtml",valueList);
}