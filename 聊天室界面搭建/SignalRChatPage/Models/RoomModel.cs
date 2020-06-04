﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using SignalRChatPage.CustomerAttr;

namespace SignalRChatPage.Models
{
    //请参考MSDN上的模型验证
    public class RoomModel
    {       
        [Required(ErrorMessage="用户名不能为空")]         //测试修改默认的提示信息
        [Remote(action:"VeryName",controller: "RoomEntrance")]
        public string NickName { get; set; }
        [Required]
        [StringLength(6,MinimumLength =6,ErrorMessage ="房间号长度不满足要求")]
        public string RoomNo { get; set; }
        [Required]
		//[Room]  //自定义特性的使用
        [StringLength(6,MinimumLength =6,ErrorMessage ="房间密码不满足要求")]
        public string RoomPassword { get; set; }
    }
}
