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
    internal class BoardTile : Button
    {
        private struct Position
        {
            internal int m_Row;
            internal int m_Col;
            public Position(int i_Row, int i_Col)
            {
                m_Row = i_Row;
                m_Col = i_Col;
            }
        }

        private readonly int r_TileSize;
        private Position m_Position;
        public event ChoseInvokerEventHandler Chosen;

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

        public BoardTile(int i_Row, int i_Col, int i_TileSize)
        {
            m_Position = new Position(i_Row, i_Col);
            r_TileSize = i_TileSize;
            Width = r_TileSize;
            Height = r_TileSize;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Chosen != null)
            {
                Chosen.Invoke(this);
            }
        }
    }
}
