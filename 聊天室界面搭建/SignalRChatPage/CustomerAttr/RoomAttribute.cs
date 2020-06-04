using SignalRChatPage.Models;
using System.ComponentModel.DataAnnotations;
using System;

//请参考MSDN模型验证 自定义模型验证
namespace SignalRChatPage.CustomerAttr
{
	public class RoomAttribute:ValidationAttribute{		
		protected override ValidationResult IsValid(object value,ValidationContext validationContext)
		{
			Console.WriteLine($"输出[Room]属性下对应的value值：{value}");
			var room=(RoomModel)validationContext.ObjectInstance;
			if(string.IsNullOrEmpty(room.NickName))
			{
				return new ValidationResult(GetErrorMessage());
			}
			return ValidationResult.Success;
		}
		public string GetErrorMessage()
		{
			return "请检查用户名是否为空";
		}
	}
}
