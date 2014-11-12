using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class AddonList : UserControl
    {
        #region private class ItemContainer
        private class ItemContainer
        {
            public string Item;
            public bool IsChecked;

            public ItemContainer(string item, bool isChecked)
            {
                Item = item;
                IsChecked = isChecked;
            }

            public override string ToString()
            {
                return Item.ToString();
            }
        }
        #endregion
        public event EventHandler CheckedChanged;
        protected virtual void OnCheckedChanged()
        {
            if (CheckedChanged != null)
                CheckedChanged(this, null);
        }
        public event EventHandler SelectedIndexChanged;

        private const int COL_IMAGE_WIDTH = 13;
        private const int COL_IMAGE_SPACE = 2;

        private Image _ImageChecked = null;
        private Image _ImageUnchecked = null;

        public AddonList()
        {
            InitializeComponent();
        }

        public Image ImageChecked
        {
            get { return _ImageChecked; }
            set { _ImageChecked = value;  }
        }
        public Image ImageUnchecked
        {
            get { return _ImageUnchecked; }
            set { _ImageUnchecked = value; }
        }

        public int Count
        {
            get
            {
                return _Listbox.Items.Count;
            }
        }
        public void Clear()
        {
            _Listbox.SelectedIndex = -1;
            _Listbox.Items.Clear();
        }
        public void Add(string item, bool isChecked)
        {
            _Listbox.Items.Add(new ItemContainer(item, isChecked));
            OnCheckedChanged();
            Invalidate();
        }
        public void Remove(string item)
        {
            _Listbox.Items.Remove(item);
            Invalidate();
        }
        public string this[int i]
        {
            get
            {
                return (_Listbox.Items[i] as ItemContainer).Item;
            }
        }
        public string SelectedItem
        {
            get
            {
                if (_Listbox.SelectedItem == null)
                    return null;
                else
                    return (_Listbox.SelectedItem as ItemContainer).Item;
            }
        }       
        public int SelectedIndex
        {
            get
            {
                return _Listbox.SelectedIndex;
            }
            set
            {
                _Listbox.SelectedIndex = value;
            }
        }      
        public ListBox.SelectedIndexCollection SelectedIndices
        {
            get
            {
                return _Listbox.SelectedIndices;
            }
        }
        public void SetItemCheckState(int index, bool isChecked)
        {
            if (index >= _Listbox.Items.Count)
                throw new ArgumentOutOfRangeException();

            (_Listbox.Items[index] as ItemContainer).IsChecked = isChecked;

            OnCheckedChanged();
            
            Invalidate();
        }
        public bool GetItemCheckState(int index)
        {
            if (index >= _Listbox.Items.Count)
                throw new ArgumentOutOfRangeException();

            return (_Listbox.Items[index] as ItemContainer).IsChecked;
        }

        private void _Listbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                ItemContainer item = _Listbox.Items[e.Index] as ItemContainer;
                if (item != null)
                {
                    e.DrawBackground();

                    SolidBrush foreBrush;
                    if (this.Enabled)
                        foreBrush = new SolidBrush(e.ForeColor);
                    else
                        foreBrush = new SolidBrush(SystemColors.ControlDark);

                    int x, y;

                    //
                    // Checked/Unchecked
                    //
                    x = COL_IMAGE_SPACE - 2;
                    y = e.Bounds.Top + ((e.Bounds.Height - COL_IMAGE_WIDTH) / 2);
                    if (item.IsChecked && (_ImageChecked != null))
                        e.Graphics.DrawImage(_ImageChecked, new Rectangle(x, y, COL_IMAGE_WIDTH, COL_IMAGE_WIDTH), new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);
                    else if (!item.IsChecked && (_ImageUnchecked != null))
                        e.Graphics.DrawImage(_ImageUnchecked, new Rectangle(x, y, COL_IMAGE_WIDTH, COL_IMAGE_WIDTH), new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);
                    x += COL_IMAGE_WIDTH + COL_IMAGE_SPACE;

                    // 
                    // Name
                    //
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Near;
                        sf.FormatFlags = StringFormatFlags.LineLimit;
                        sf.Trimming = StringTrimming.EllipsisCharacter;
                        sf.LineAlignment = StringAlignment.Center;
                        int w = e.Bounds.Width - (COL_IMAGE_SPACE + COL_IMAGE_WIDTH + COL_IMAGE_SPACE);
                        using (SolidBrush brush = new SolidBrush(e.ForeColor))
                        {
                            e.Graphics.DrawString(item.ToString(), e.Font, foreBrush, new Rectangle(x, e.Bounds.Top, w, e.Bounds.Height), sf);
                        }
                    }

                    foreBrush.Dispose();
                }
            }

        }
        private void _Listbox_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
        private void _Listbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < COL_IMAGE_WIDTH + COL_IMAGE_SPACE)
            {
                int i  = _Listbox.IndexFromPoint(e.Location);
                if ((i >= 0) && (i < _Listbox.Items.Count))
                {
                    ItemContainer container = _Listbox.Items[i] as ItemContainer;
                    container.IsChecked = !container.IsChecked;
                    OnCheckedChanged();
                    Invalidate();
                }
            }
        }

        private void _Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);
        }
    }
}
