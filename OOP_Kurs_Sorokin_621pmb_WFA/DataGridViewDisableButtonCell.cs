using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabled;
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public DataGridViewDisableButtonCell()
        {
            this.enabled = true;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (!this.enabled)
            {
                // Меняем стиль кнопки на "отключённый"
                cellStyle.ForeColor = Color.Gray;
                cellStyle.BackColor = Color.LightGray;
            }
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }
    }
}
