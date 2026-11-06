using Other;
using System.Windows;

namespace Aimmy2.MouseMovementLibraries.GHubSupport
{
    internal class LGHubMain
    {
        public bool Load()
        {
            if (!RequirementsManager.CheckForGhub())
            {
                MessageBox.Show("很遗憾，未检测到 LG HUB 鼠标。", "Aimmy");
                return false;
            }

            if (RequirementsManager.IsMemoryIntegrityEnabled())
            {
                try
                {
                    LGMouse.Open();
                    LGMouse.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("很遗憾，LG HUB 鼠标移动模式无法正常运行。\n" + ex.ToString(), "Aimmy");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("内存完整性已启用。请将其关闭以使用 LG HUB 鼠标移动模式。", "Aimmy");
                return false;
            }
        }
    }
}