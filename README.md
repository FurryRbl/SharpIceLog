# SharpIceLog

## 许可证

采用[MIT](https://github.com/FurryRbl/SharpIceLog/blob/main/LICENSE)分发

## 使用

### 安装方法1

[从此处下载最新dll](https://github.com/FurryRbl/SharpIceLog/releases)

在你的项目中引用下载的dll

### 安装方法2

在NuGet包管理中搜索SharpIceLog并安装,或使用安装命令

``` bash
Install-Package SharpIceLog
```

### 在项目使用

在代码中引用

```CSharp
using SharpIceLog;
```

可使用以下函数

```CSharp
Logger.LogInfo("信息");
Logger.LogWarning("警告信息");
Logger.LogError("警告信息");
Logger.LogFatal("致命错误信息");
Logger.LogDebug("调试信息");
```

## 示例

代码

```CSharp
using SharpIceLog;

namespace Demo
{
    public class DemoMain
    {
        public static void Main()
        {
            Logger.LogInfo("Test");
        }
    }
}
```

结果

```CSharp
[08:53:20] [Demo.DemoMain.Main/INFO]: Test
```
