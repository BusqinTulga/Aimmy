namespace Other
{
    /// <summary>
    /// 界面文本本地化（简体中文）。
    /// 仅翻译显示文本；配置键、字典键和日志内部标识始终保持英文，
    /// 以免破坏已有配置文件与运行逻辑。
    /// </summary>
    internal static class Loc
    {
        private static readonly Dictionary<string, string> Translations = new(StringComparer.Ordinal)
        {
            // ── 通用 ──
            ["Unlimited"] = "无限制",
            ["Best Confidence"] = "最高置信度",
            ["Primary"] = "主显示器",
            ["Middle"] = "中部",
            ["Center"] = "居中",
            ["Top"] = "顶部",
            ["Bottom"] = "底部",
            ["Circle"] = "圆形",
            ["Rectangle"] = "矩形",
            ["Linear"] = "线性",
            ["Exponential"] = "指数",
            ["Adaptive"] = "自适应",
            ["Perlin Noise"] = "Perlin 噪声",
            ["Cubic Bezier"] = "三次贝塞尔",
            ["DirectX"] = "DirectX",
            ["GDI+"] = "GDI+",
            ["SendInput"] = "SendInput",
            ["Mouse Event"] = "鼠标事件",
            ["Mouse"] = "鼠标",
            ["N/A"] = "N/A",

            // ── 瞄准菜单 ──
            ["Aim Assist"] = "瞄准辅助",
            ["Aim Config"] = "瞄准配置",
            ["Constant AI Tracking"] = "持续 AI 追踪",
            ["Sticky Aim"] = "粘性瞄准",
            ["Sticky Aim Threshold"] = "粘性瞄准阈值",
            ["Aim Keybind"] = "瞄准按键",
            ["Second Aim Keybind"] = "备用瞄准按键",
            ["Mouse Movement Method"] = "鼠标移动方式",
            ["Movement Path"] = "移动轨迹",
            ["Detection Area Type"] = "检测区域类型",
            ["Aiming Boundaries Alignment"] = "瞄准边界对齐",
            ["Mouse Sensitivity (+/-)"] = "鼠标灵敏度 (+/-)",
            ["Mouse Jitter"] = "鼠标抖动",
            ["Y Axis Percentage Adjustment"] = "Y 轴百分比调整",
            ["X Axis Percentage Adjustment"] = "X 轴百分比调整",
            ["Y Offset (Up/Down)"] = "Y 偏移（上/下）",
            ["Y Offset (%)"] = "Y 偏移 (%)",
            ["X Offset (Left/Right)"] = "X 偏移（左/右）",
            ["X Offset (%)"] = "X 偏移 (%)",
            ["Predictions"] = "预测",
            ["Prediction Method"] = "预测方式",
            ["Kalman Filter"] = "卡尔曼滤波",
            ["Shall0e's Prediction"] = "Shall0e 预测",
            ["wisethef0x's EMA Prediction"] = "wisethef0x EMA 预测",
            ["Kalman Lead Time"] = "卡尔曼提前量",
            ["WiseTheFox Lead Time"] = "WiseTheFox 提前量",
            ["Shalloe Lead Multiplier"] = "Shalloe 提前量倍数",
            ["EMA Smoothening"] = "EMA 平滑",
            ["Auto Trigger"] = "自动扳机",
            ["Cursor Check"] = "光标检查",
            ["Spray Mode"] = "连发模式",
            ["Auto Trigger Delay"] = "自动扳机延迟",
            ["FOV Config"] = "视野配置",
            ["FOV"] = "视野 (FOV)",
            ["Dynamic FOV"] = "动态视野",
            ["Third Person Support"] = "第三人称支持",
            ["Dynamic FOV Keybind"] = "动态视野按键",
            ["FOV Style"] = "视野样式",
            ["FOV Color"] = "视野颜色",
            ["FOV Size"] = "视野大小",
            ["Dynamic FOV Size"] = "动态视野大小",
            ["ESP Config"] = "目标显示配置",
            ["Show Detected Player"] = "显示检测目标",
            ["Show AI Confidence"] = "显示 AI 置信度",
            ["Show Tracers"] = "显示追踪线",
            ["Tracer Position"] = "追踪线位置",
            ["Detected Player Color"] = "检测目标颜色",
            ["AI Confidence Font Size"] = "AI 置信度字号",
            ["Corner Radius"] = "圆角",
            ["Border Thickness"] = "边框粗细",
            ["Opacity"] = "不透明度",
            ["Closest to Center Screen"] = "最接近屏幕中心",
            ["Closest to Mouse"] = "最接近鼠标",
            ["Razer Synapse (Require Razer Peripheral)"] = "Razer Synapse（需要雷蛇外设）",
            ["ddxoft Virtual Input Driver"] = "ddxoft 虚拟输入驱动",

            // ── 滑块单位 ──
            ["Pixels"] = "像素",
            ["Sensitivity"] = "灵敏度",
            ["Jitter"] = "抖动",
            ["Offset"] = "偏移",
            ["Percent"] = "百分比",
            ["Seconds"] = "秒",
            ["Frames"] = "帧",
            ["Amount"] = "程度",
            ["Size"] = "大小",
            ["Radius"] = "半径",
            ["Thickness"] = "粗细",
            ["FPS"] = "FPS",
            ["% Confidence"] = "% 置信度",

            // ── 设置菜单 ──
            ["Model Settings"] = "模型设置",
            ["Settings Menu"] = "设置菜单",
            ["Theme Settings"] = "主题设置",
            ["Screen Settings"] = "屏幕设置",
            ["Image Size"] = "图像尺寸",
            ["AI FPS Limit"] = "AI FPS 上限",
            ["Run Performance Helper"] = "运行性能助手",
            ["Target Class"] = "目标类别",
            ["AI Minimum Confidence"] = "AI 最低置信度",
            ["Enable Model Switch Keybind"] = "启用模型切换按键",
            ["Model Switch Keybind"] = "模型切换按键",
            ["Emergency Stop Keybind"] = "紧急停止按键",
            ["Collect Data While Playing"] = "游戏时收集数据",
            ["Auto Label Data"] = "自动标注数据",
            ["Mouse Background Effect"] = "鼠标背景效果",
            ["UI TopMost"] = "窗口置顶",
            ["Debug Mode"] = "调试模式",
            ["Save Config"] = "保存配置",
            ["Screen Capture Method"] = "屏幕捕获方式",
            ["StreamGuard"] = "直播防护",
            ["Refresh Displays"] = "刷新显示器",
            ["Focus Display"] = "焦点显示器",
            ["No displays detected"] = "未检测到显示器",
            ["Primary Display Selected"] = "已选择主显示器",

            // ── 模型菜单 ──
            ["Local Models"] = "本地模型",
            ["Local Configs"] = "本地配置",
            ["Downloadable Models"] = "可下载模型",
            ["Downloadable Configs"] = "可下载配置",
            ["Loaded Model: N/A"] = "已加载模型：N/A",
            ["Loaded Config: N/A"] = "已加载配置：N/A",
            ["There is no downloadable models at the moment, please check again later."] =
                "目前没有可下载的模型，请稍后再试。",
            ["There is no downloadable configs at the moment, please check again later."] =
                "目前没有可下载的配置，请稍后再试。",
            ["Loading store..."] = "正在加载商店...",
            ["Failed to load store"] = "加载商店失败",

            // ── 关于菜单 ──
            ["Aimmy is free and open source"] = "Aimmy 免费且开源",
            ["Universal Second Eye"] = "通用第二视觉",
            ["Check for Updates"] = "检查更新",
            ["CORE TEAM"] = "核心团队",
            ["KEY CONTRIBUTORS"] = "主要贡献者",
            ["And the entire Aimmy community"] = "以及整个 Aimmy 社区",
            ["Thank you for your support!"] = "感谢你的支持！",
            ["View on GitHub"] = "在 GitHub 上查看",
            ["Join our Discord"] = "加入我们的 Discord",
            ["Loading system specs..."] = "正在读取系统信息...",

            // ── 保存配置窗口 ──
            ["Save Configuration"] = "保存配置",
            ["Insert Config Name Here"] = "在此输入配置名称",
            ["Insert Recommended Model Name Here"] = "在此输入推荐模型名称",
            ["Can this model be found in the \"Downloadable Models\" Menu?"] =
                "此模型能否在“可下载模型”菜单中找到？",
            ["Save"] = "保存",

            // ── LG 下载器 ──
            ["LG Downloader"] = "LG Hub 下载器",
            ["Please click on a button below to download LG Hub."] = "请点击下方按钮下载 LG Hub。",
            ["LG Direct"] = "LG 官方直链",
            ["Supercomet CDN"] = "Supercomet CDN",
            ["99'developer's GitHub"] = "99'developer 的 GitHub",

            // ── 颜色选择器 ──
            ["OVERLAY Color Picker"] = "颜色选择器",
            ["Theme Color"] = "主题颜色",
            ["ESP Color"] = "ESP 颜色",
            ["Brightness"] = "亮度",
            ["Current Theme Color"] = "当前主题颜色",
            ["Media Control"] = "媒体控制",
            ["Drag & Drop Media Here"] = "将媒体文件拖放到此处",

            // ── 性能助手 ──
            ["Aimmy Performance Helper"] = "Aimmy 性能助手",
            ["Performance Helper"] = "性能助手",
            ["Run Performance Helper?"] = "运行性能助手？",
            ["Benchmark Aimmy once and get a size + FPS cap for this PC."] =
                "对 Aimmy 进行一次基准测试，获取适合本机的图像尺寸和 FPS 上限。",
            ["Closing will remind you later."] = "关闭后稍后会再次提醒你。",
            ["Opening benchmark panel."] = "正在打开基准测试面板。",
            ["No thanks"] = "不用了",
            ["No Thanks"] = "不用了",
            ["Run Check"] = "开始检查",
            ["Run Test"] = "开始测试",
            ["Run Again"] = "再次测试",
            ["Try Again"] = "重试",
            ["Close"] = "关闭",
            ["Apply Settings"] = "应用设置",
            ["Running"] = "运行中",
            ["Selected Avg FPS"] = "所选平均 FPS",
            ["Avg CPU Load"] = "平均 CPU 占用",
            ["Avg GPU Load"] = "平均 GPU 占用",
            ["Selected Cap"] = "所选上限",
            ["Quick full-speed check"] = "快速全速检测",
            ["Aimmy will test image sizes, then recommend a size + FPS cap for your goal. Lower image size can cut resource use, but can lose detail on small targets."] =
                "Aimmy 会测试多种图像尺寸，然后根据你的目标推荐尺寸和 FPS 上限。较小的图像尺寸能降低资源占用，但可能丢失小目标的细节。",
            ["WHAT DO YOU WANT?"] = "你希望达到什么目标？",
            ["Fastest"] = "最快",
            ["Balanced"] = "均衡",
            ["Fastest Detections"] = "最快检测",
            ["Quality"] = "画质",
            ["High Speed"] = "高速",
            ["Lowest Resources"] = "最低占用",
            ["Lowest"] = "最低占用",
            ["Freshest detections. Uses more CPU/GPU."] = "最新的检测结果，会占用更多 CPU/GPU。",
            ["Good detection speed with reasonable load."] = "检测速度良好，资源占用合理。",
            ["Lowest CPU/GPU use while staying near 60 FPS, or 30 FPS if needed."] =
                "尽可能降低 CPU/GPU 占用，同时保持接近 60 FPS；必要时可降至 30 FPS。",
            ["WHAT HAPPENS"] = "会发生什么",
            ["5s+ warmup + 10s timed AI loop per size"] = "每种尺寸预热 5 秒以上，然后计时运行 AI 循环 10 秒",
            ["Mouse movement and clicks stay off"] = "不会执行鼠标移动和点击",
            ["Fastest, Balanced, and Lowest Resource picks are labeled"] = "会标注最快、均衡和最低占用的选项",
            ["No training frames are saved"] = "不会保存训练帧",
            ["Preparing benchmark"] = "正在准备基准测试",
            ["Starting..."] = "正在启动...",
            ["Benchmark stopped"] = "基准测试已停止",
            ["Stopping benchmark"] = "正在停止基准测试",
            ["Restoring the loaded model before closing."] = "关闭前正在恢复已加载的模型。",
            ["Close this helper or try again after loading a model."] = "请关闭此助手，或在加载模型后重试。",
            ["Close this helper or run the test again after the model settles."] = "请关闭此助手，或等模型稳定后重新测试。",
            ["No stable AI-loop sample was captured."] = "未能采集到稳定的 AI 循环样本。",
            ["Select Fastest, Balanced, or Lowest Resource, then apply that pair."] =
                "请选择最快、均衡或最低占用，然后应用对应的设置。",
            ["Applying selected size and FPS cap..."] = "正在应用所选尺寸和 FPS 上限...",
            ["Could not apply the selected pair. Model settings were left unchanged."] =
                "无法应用所选设置，模型设置保持不变。",
            ["You can change these later in Model Settings."] = "稍后可在“模型设置”中修改这些内容。",
            ["No stable sample"] = "无稳定样本",

            // ── 启动窗口 ──
            ["AI PRECISION TARGETING"] = "AI 精准瞄准",
            ["INITIALIZING AIMMY AI"] = "正在初始化 AIMMY AI",
            ["LAUNCHING INTERFACE"] = "正在启动界面",

            // ── 提示 / 对话框 ──
            ["Error"] = "错误",
            ["Aimmy V2"] = "Aimmy V2",
            ["Aimmy AI"] = "Aimmy AI",
            ["Hi, it is made aware that you are running Aimmy without extracting it from the zip file. Please extract Aimmy from the zip file or Aimmy will not be able to run properly.\n\nThank you."] =
                "检测到你正在未解压的情况下运行 Aimmy。请先将 Aimmy 从压缩包中解压，否则 Aimmy 无法正常运行。\n\n谢谢。",
            ["Startup animation failed"] = "启动动画失败",
            ["Suggested Model - Aimmy"] = "推荐模型 - Aimmy",
            ["Aimmy - LG HUB Mouse Movement"] = "Aimmy - LG HUB 鼠标移动",
            ["LG HUB is not running, is it installed?"] = "LG HUB 未运行，是否已安装？",
            ["Would you like to install it?"] = "是否要安装它？",
            ["LG HUB install is improper, would you like to install it?"] = "LG HUB 安装不完整，是否要重新安装？",
            ["A config already exists with the same name, would you like to overwrite it?"] =
                "已存在同名配置，是否覆盖？",
            ["Configuration Saver"] = "配置保存器",

            // ── 工具提示 ──
            ["Turn aim assist on or off. You must load a model first."] =
                "开启或关闭瞄准辅助。请先加载模型。",
            ["Always track targets without holding a key. When off, you must hold the aim keybind."] =
                "无需按住按键即可持续追踪目标。关闭时，需要按住瞄准按键。",
            ["Lock onto a target until it moves out of range instead of switching targets."] =
                "锁定一个目标，直到它移出范围，而不是切换到其他目标。",
            ["How far a target must move before switching to a new one. Higher = stays locked longer."] =
                "目标移动多远后才切换到新目标。数值越高，锁定时间越长。",
            ["The key you hold to activate aim assist."] = "按住此键以激活瞄准辅助。",
            ["An alternate key to activate aim assist."] = "用于激活瞄准辅助的备用按键。",
            ["How mouse movements are sent. Try different options if aim assist isn't working."] =
                "鼠标移动的发送方式。如果瞄准辅助无效，可以尝试其他选项。",
            ["The curve style used when moving to a target. Affects how natural the movement looks."] =
                "移动到目标时使用的轨迹样式，影响移动的自然程度。",
            ["How targets are prioritized. Center screen is best for most games."] =
                "目标优先级计算方式。对大多数游戏来说，屏幕中心效果最好。",
            ["Where to aim on the detected target box. Center is usually best."] =
                "在检测到的目标框上瞄准的位置。通常选择居中效果最好。",
            ["How fast the aim moves. Lower = faster and snappier, higher = slower and smoother."] =
                "瞄准移动速度。数值越低越快越灵敏，数值越高越慢越平滑。",
            ["Adds random small movements to make aim look more human-like."] =
                "加入随机小幅移动，让瞄准看起来更像真人。",
            ["Enable the Y Offset (%) slider to adjust aim vertically by percentage."] =
                "启用 Y 偏移 (%) 滑块，以百分比方式垂直调整瞄准点。",
            ["Enable the X Offset (%) slider to adjust aim horizontally by percentage."] =
                "启用 X 偏移 (%) 滑块，以百分比方式水平调整瞄准点。",
            ["Move aim point up (negative) or down (positive) in pixels."] =
                "以像素为单位上移（负值）或下移（正值）瞄准点。",
            ["Move aim point up or down as a percentage of the target box height."] =
                "按目标框高度的百分比上移或下移瞄准点。",
            ["Move aim point left (negative) or right (positive) in pixels."] =
                "以像素为单位左移（负值）或右移（正值）瞄准点。",
            ["Move aim point left or right as a percentage of the target box width."] =
                "按目标框宽度的百分比左移或右移瞄准点。",
            ["Predict where a moving target will be. Helps track fast-moving targets."] =
                "预测移动目标的未来位置，有助于追踪快速移动的目标。",
            ["The algorithm used to predict target movement. Try different ones to see what works best."] =
                "用于预测目标移动的算法。可以尝试不同算法，找到最适合的一种。",
            ["How far ahead to predict target position. Higher = more prediction, may overshoot."] =
                "提前预测目标位置的时间。数值越高预测越远，但可能过度瞄准。",
            ["How many frames ahead to predict. Higher = more prediction, may overshoot."] =
                "提前预测的帧数。数值越高预测越远，但可能过度瞄准。",
            ["Smooth out aim movements to reduce jitter and make tracking steadier."] =
                "平滑瞄准移动，减少抖动，让追踪更稳定。",
            ["How much smoothing to apply. Lower = smoother but slower, higher = faster but jittery."] =
                "平滑程度。数值越低越平滑但越慢，数值越高越快但抖动更明显。",
            ["Automatically click when a target is detected in your crosshair area."] =
                "当准星区域检测到目标时自动点击。",
            ["Only trigger when cursor is directly on target. More accurate but may miss some shots."] =
                "仅当光标直接位于目标上时触发。更精确，但可能漏掉一些射击机会。",
            ["Hold down fire instead of single clicks. Good for automatic weapons."] =
                "按住开火而不是单次点击，适合全自动武器。",
            ["Wait time before firing after detecting a target. Helps avoid accidental shots."] =
                "检测到目标后等待多久再开火，有助于避免误触。",
            ["Show a circle on screen indicating the detection area."] = "在屏幕上显示圆形以指示检测区域。",
            ["Change FOV size when holding a key. Useful for scoping in."] =
                "按住按键时改变视野大小，适合开镜时使用。",
            ["Adjust FOV position for third-person camera games."] = "为第三人称视角游戏调整视野位置。",
            ["The key to hold for switching to the dynamic FOV size."] = "按住此键切换到动态视野大小。",
            ["Shape of the FOV overlay. Circle is most common."] = "视野叠加层的形状。圆形最常见。",
            ["Size of the detection area. Smaller = more precise, larger = wider coverage."] =
                "检测区域大小。越小越精确，越大覆盖范围越广。",
            ["FOV size when holding the Dynamic FOV key. Usually smaller for scoped aim."] =
                "按住动态视野按键时的视野大小。开镜瞄准时通常更小。",
            ["Draw a box around detected targets on screen."] = "在屏幕上为检测到的目标绘制方框。",
            ["Display how confident the AI is about each detection (0-100%)."] =
                "显示 AI 对每个检测结果的置信度（0-100%）。",
            ["Draw lines from screen edge to detected targets."] = "从屏幕边缘向检测到的目标绘制连线。",
            ["Where tracer lines start from on the screen."] = "追踪线在屏幕上的起点位置。",
            ["Text size for the confidence percentage display."] = "置信度百分比文字的大小。",
            ["How rounded the detection box corners are. 0 = sharp corners."] =
                "检测框圆角大小。0 表示直角。",
            ["How thick the detection box outline is."] = "检测框轮廓的粗细。",
            ["How see-through the detection box is. 0 = invisible, 1 = solid."] =
                "检测框的透明程度。0 表示完全透明，1 表示完全不透明。",
            ["Resolution the AI uses for detection. Smaller = faster but less accurate."] =
                "AI 检测使用的分辨率。越小速度越快，但精度越低。",
            ["Caps the AI loop to reduce CPU/GPU load. 0 keeps Aimmy running at full speed."] =
                "限制 AI 循环频率以降低 CPU/GPU 占用。0 表示让 Aimmy 全速运行。",
            ["Open the performance helper again for the currently loaded model."] =
                "为当前加载的模型重新打开性能助手。",
            ["Which type of target to aim at. Best Confidence picks the most certain detection."] =
                "选择要瞄准的目标类型。“最高置信度”会选择最确定的检测结果。",
            ["How sure the AI must be before targeting. Higher = fewer false detections but may miss targets."] =
                "AI 必须达到多高的置信度才会瞄准。数值越高误检越少，但可能漏掉目标。",
            ["Allow switching between AI models using a hotkey."] = "允许使用热键在 AI 模型之间切换。",
            ["Press this key to cycle through available AI models."] = "按下此键可循环切换可用的 AI 模型。",
            ["Press this key to immediately stop all aim assist functions."] =
                "按下此键立即停止所有瞄准辅助功能。",
            ["Save screenshots of detections for training new AI models."] =
                "保存检测截图，用于训练新的 AI 模型。",
            ["Automatically label collected screenshots with detection data."] =
                "使用检测数据自动标注收集到的截图。",
            ["Show a visual effect on the UI when moving your mouse."] = "移动鼠标时在界面上显示视觉效果。",
            ["Keep this window above all other windows."] = "让此窗口始终位于其他窗口之上。",
            ["Show extra information useful for troubleshooting problems."] =
                "显示有助于排查问题的额外信息。",
            ["Save your current settings to a file you can load later."] =
                "将当前设置保存为文件，方便以后加载。",
            ["How the screen is captured. DirectX is faster, GDI+ works on more systems."] =
                "屏幕捕获方式。DirectX 更快，GDI+ 兼容性更好。",
            ["Hide the overlay from screen recordings and streams. - Appears in system tray."] =
                "在录屏和直播中隐藏叠加层。- 会显示在系统托盘中。",
            ["Update the list of available monitors."] = "更新可用显示器列表。",
        };

        /// <summary>返回中文显示文本；没有对应翻译时原样返回。</summary>
        public static string T(string? text)
        {
            if (string.IsNullOrEmpty(text)) return text ?? string.Empty;
            return Translations.TryGetValue(text, out var translated) ? translated : text;
        }

        /// <summary>翻译带占位参数的文本片段（按前缀匹配动态内容）。</summary>
        public static string TFormat(string? format, params object?[] args)
            => string.Format(T(format), args);
    }
}
