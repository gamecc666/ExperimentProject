详细的读取信息操作参考：
public IActionResult TableSelectEvent(string id)
{
	string tablename = id;
	List<string> valueList = new List<string>();
	string path = @"D:\ZYAPPXmlData\BackData\萨德对朝鲜半岛的影响.xml";
	if (string.Compare(tablename, "萨德时间对比图")==0) {
		XElement Root = XElement.Load(path);
		IEnumerable<XElement> childNodes = from data in Root.Descendants("Data").Elements()
										   select data;
		foreach(XElement node in childNodes)
		{
			Console.WriteLine("名字：" + node.Name + " ||值：" + node.Value);
			valueList.Add(node.Value);
		}
	};
	return View("~/Views/MainContent/ScenarioExcuteEvent.cshtml",valueList);
}