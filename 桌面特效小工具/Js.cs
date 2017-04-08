using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桌面特效小工具
{
    class Js
    {
        private static string JsCode;
        public static string SetJsCode(string YourJsCode)
        {
            JsCode = "window.onload = function(){var canvas = document.getElementById('canvas');var context = canvas.getContext('2d');var W = screen.width;var H = screen.height;canvas.width = W;canvas.height = H;var fontSize = 15;var colunms = Math.floor(W / fontSize);var drops = [];for (var i = 0; i < colunms; i++){drops.push(0);}var str = 'Windows Tools By Information Manger 1502Chenjie';function draw(){context.fillStyle = 'rgba(0,0,0,0.05)';context.fillRect(0, 0, W, H);context.font = '1000 ' + fontSize + 'px  微软雅黑';context.fillStyle = '#00cc33';for (var i = 0; i < colunms; i++){var index = Math.floor(Math.random() * str.length);var x = i * fontSize;var y = drops[i] * fontSize;context.fillText(str[index], x, y);if (y >= canvas.height && Math.random() > 0.99){drops[i] = 0;}drops[i]++;}};function randColor(){var r = Math.floor(Math.random() * 256);var g = Math.floor(Math.random() * 256);var b = Math.floor(Math.random() * 256);return 'rgb(' + r + ',' + g + ',' + b + ')';}draw();setInterval(draw, 30);};";
            return JsCode;
        }
    }
}
