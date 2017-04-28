 /SAFESEH:NO
/KEYFILE:xxxx 
 



引用程序集没有强名称解决办法
为项目添加强名称方法：
1.右键单击项目，打开属性窗口;
2.在属性窗口里选择《签名》标签，选中为程序集签名的选项，在下拉列表里选择新建,如下图所示：





3.打开新建签名窗口，输入签名的名称密码等内容，
单击确定后，签名添加完成。

 
为没有源码的DLL文件添加强名称
 
如果项目中引用了其他没有源码的dll文件，并且此dll文件是没有强名称的程序集，则编译时会出现类似 "Assembly generation failed -- 引用的程序集 'xxxxxxxxxxx' 没有强名称" 这样的错误。
我这里引用的是Interop.Scripting.dll程序集，它不是强名称的，则需要进行以下操作：
1.打开SDK 命令提示窗口;
 


2.创建一个新的随机密钥对:
sn -k Interop.Scripting.snk
3.反编译目标程序集
ildasm Interop.Scripting.dll /out=Interop.Scripting.il
3.重新编译，附带强命名参数
ilasm Interop.Scripting.il /dll /resource=Interop.Scripting.res /key=Interop.Scripting.snk /optimize
4.验证签名信息
sn -v Interop.Scripting.dll

OK,将生成的dll文件重新引入到项目中然后编译。

