using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine;

namespace GUI
{
    public delegate void ChoseInvokerEventHandler(object sender);
    class BoardTile : Button
    {
        struct Pos
        {
            internal int m_Row;
            internal int m_Col;
            public Pos(int i_Row, int i_Col)
            {
                m_Row = i_Row;
                m_Col = i_Col;
            }
        }

        Pos m_Position;
        Engine m_Engine;
        public event ChoseInvokerEventHandler m_Chosen;

        public int Row
        {
            get
            {
                return m_Position.m_Row;
            }
        }
        public int Col
        {
            get
            {
                return m_Position.m_Col;
            }
        }
        public BoardTile(Engine i_Engine, int i_Row, int i_Col)
        {
            m_Engine = i_Engine;
            m_Position = new Pos(i_Row, i_Col);
            this.Width = 50;
            this.Height = 50;

        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (m_Chosen != null)
            {
                m_Chosen.Invoke(this);
            }
        }
    }
}
