using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;
using System.ComponentModel;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public abstract class MyDataContexts : INotifyPropertyChanged
        {
            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            #endregion
        }

        public class CircleDC : MyDataContexts
        {
            double _radiousXY = 0;
            bool _isRotating = false;

            public CircleDC(double radiousXY)
            {
                _radiousXY = radiousXY;
            }

            public double RadiousXY
            {
                get { return _radiousXY; }
                set
                {
                    if (_radiousXY != value)
                    {
                        _radiousXY = value;
                        OnPropertyChanged("RadiousXY");
                    }
                }
            }

            public bool IsRotating
            {
                get { return _isRotating; }
                set
                {
                    _isRotating = value;
                    OnPropertyChanged("IsRotating");
                }
            }
        }

        public class CrossDC : MyDataContexts
        {
            double _angle1 = 45;
            double _angle2 = -45;
            bool _isRotating = false;

            public CrossDC(double angle1, double angle2)
            {
                _angle1 = angle1;
                _angle2 = angle2;
            }

            public double Angle1
            {
                get { return _angle1; }
                set
                {
                    if (_angle1 != value)
                    {
                        _angle1 = value;
                        OnPropertyChanged("Angle1");
                    }
                }
            }
            public double Angle2
            {
                get { return _angle2; }
                set
                {
                    if (_angle2 != value)
                    {
                        _angle2 = value;
                        OnPropertyChanged("Angle2");
                    }
                }
            }

            public bool IsRotating
            {
                get { return _isRotating; }
                set
                {
                    _isRotating = value;
                    OnPropertyChanged("IsRotating");
                }
            }
        }

        public class BorderDC : MyDataContexts
        {
            private bool _isBlinking = false;

            public bool IsBlinking
            {
                get { return _isBlinking; }
                set
                {
                    if (_isBlinking != value)
                    {
                        _isBlinking = value;
                        OnPropertyChanged("IsBlinking");
                    }
                }
            }
        }

        const byte FILLED_WITH_CIRCLE = 1;
        const byte FILLED_WITH_CROSS = 2;

        int _numOfPlayers = 2;

        bool _itsMyTurn = false;
        bool _toBeStartedByMe = false;
        bool _isGameOver = false;
        bool _drawCircle = true;
        int _numFilled = 0;

        ControlTemplate _crossTemplate = new ControlTemplate();
        ControlTemplate _circleTemplate;
        CrossDC _corssDataContext = new CrossDC(45, -45);
        CircleDC _circleDataContext = new CircleDC(0);

        int[][] _matches = new int[][]
        {
            new int[]{0,1,2}, 
            new int[]{3,4,5}, 
            new int[]{6,7,8},
            new int[]{0,3,6},
            new int[]{1,4,7},
            new int[]{2,5,8},
            new int[]{0,4,8},
            new int[]{2,4,6}
        };

        int[][][] _goodStart = new int[][][]
        {
            new int[][]  {new int[]{4} ,new int[]{0,2,6,8}},
            new int[][]  {new int[]{1} ,new int[]{6,8} ,new int[]{0,2}},
            new int[][]  {new int[]{7} ,new int[]{0,2} ,new int[]{6,8}},
            new int[][]  {new int[]{0} ,new int[]{4,8,6,2}}
        };

        int _myLastGoodStart = 0;


        class Cell
        {
            public Control control;
            public Border border = null;
            public byte filledWith = 0;

            public Cell(Control c)
            {
                c.DataContext = new BorderDC();
                control = c;

                Border b = c.Template.FindName("theBorder", c) as Border;
                if (b != null)
                    border = b;
                else
                    border = null;
            }
        }

        Cell[] _Cells = new Cell[9];

        public Window1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
            this.Closed += new EventHandler(Window1_Closed);
        }

        void Window1_Closed(object sender, EventArgs e)
        {
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            MainGrid.Height = this.ActualHeight - ButtonGrid.ActualHeight - 10;
            MainGrid.Width = this.ActualWidth - 10;

            this.SizeChanged += new SizeChangedEventHandler(Window1_SizeChanged);
            _crossTemplate = this.MainGrid.TryFindResource("BlueCross") as ControlTemplate;
            _circleTemplate = this.MainGrid.TryFindResource("TheCircleTemplate") as ControlTemplate;

            Control[] cells = new Control[] { B1, B2, B3, B4, B5, B6, B7, B8, B9 };
            for (int i = 0; i < _Cells.Length; i++)
                _Cells[i] = new Cell(cells[i]);

            this.Cursor = Cursors.ArrowCD;

            this.KeyUp += new KeyEventHandler(Window1_KeyUp);
        }

        void Window1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F2:
                    NewGameBtn_Click(null, null);
                    break;

                case Key.System:
                    {
                        switch (e.SystemKey)
                        {
                            case Key.N:
                                NewGameBtn_Click(null, null);
                                break;

                            case Key.D1:
                                OnePlayerBtn_Click(null, null);
                                break;

                            case Key.D2:
                                TwoPlayerBtn_Click(null, null);
                                break;

                            case Key.X:
                                ExitBtn_Click(null, null);
                                break;
                        }
                    }
                    break;
            }
        }

        void Window1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualHeight < this.MinHeight)
                this.Height = this.MinHeight;
            if (this.ActualWidth < this.MinWidth)
                this.Width = this.MinWidth;

            MainGrid.Height = this.ActualHeight - ButtonGrid.ActualHeight - 10;
            MainGrid.Width = this.ActualWidth - 10;

            MainGrid.UpdateLayout();

            foreach (Cell c in _Cells)
            {
                if (c.border.Child != null && c.border.Child is Control)
                    SetSize(c.border.Child);
            }
        }

        void SetSize(object obj)
        {
            Control c = obj as Control;
            if (c.DataContext is CircleDC)
                SetCircleSize(c);
            else if (c.DataContext is CrossDC)
                SetCrossSize(c);
        }

        void SetCircleSize(Control c)
        {
            double h = (B1.ActualWidth < B1.ActualHeight) ? B1.ActualWidth : B1.ActualHeight;
            c.Height = h / 1.25;
            c.Width = c.Height;
            (c.DataContext as CircleDC).RadiousXY = c.Height / 2;
            c.UpdateLayout();
        }

        void SetCrossSize(Control c)
        {
            double w = (B1.ActualWidth < B1.ActualHeight) ? B1.ActualWidth : B1.ActualHeight;
            c.Width = w / 1.25;
            base.UpdateLayout();
        }

        Control CreateCircle()
        {
            Control theCircle = new Control();

            theCircle.DataContext = _circleDataContext;
            SetCircleSize(theCircle);
            theCircle.Template = _circleTemplate;

            return theCircle;
        }

        Control CreateCross()
        {
            Control control = new Control();

            control.DataContext = _corssDataContext;
            SetCrossSize(control);
            control.Template = _crossTemplate;

            return control;
        }

        bool CheckIfGameOver()
        {
            _isGameOver = false;

            List<int> matchedCells = new List<int>();

            foreach (int[] m in _matches)
            {
                if ((_Cells[m[0]].filledWith & _Cells[m[1]].filledWith & _Cells[m[2]].filledWith) > 0)
                {
                    if (_numOfPlayers > 1)
                        TB_GameOver.Text = "Game Over!";
                    else
                        TB_GameOver.Text = (!_itsMyTurn) ? "YOU WIN !" : "I WIN !";
                    TB_GameOver.Visibility = Visibility.Visible;
                    if (!matchedCells.Contains(m[0]))
                        matchedCells.Add(m[0]);
                    if (!matchedCells.Contains(m[1]))
                        matchedCells.Add(m[1]);
                    if (!matchedCells.Contains(m[2]))
                        matchedCells.Add(m[2]);
                }
            }

            if (matchedCells.Count > 0)
            {
                foreach (int cIndex in matchedCells)
                    (_Cells[cIndex].control.DataContext as BorderDC).IsBlinking = true;

                if (_Cells[matchedCells[0]].filledWith == FILLED_WITH_CIRCLE)
                    _circleDataContext.IsRotating = true;
                else
                    _corssDataContext.IsRotating = true;

                _isGameOver = true;
                _toBeStartedByMe = !_toBeStartedByMe;
            }

            if (_numFilled > 8 && _isGameOver == false)
            {
                foreach (Cell c in _Cells)
                {
                    (c.control.DataContext as BorderDC).IsBlinking = true;
                }
                TB_GameOver.Text = "It's a Draw!";
                TB_GameOver.Visibility = Visibility.Visible;
                _toBeStartedByMe = !_toBeStartedByMe;
            }

            return _isGameOver;
        }

        bool AddChildIfEmpty(Border b)
        {
            if (b.Child != null)
                return false;

            Control c = b.TemplatedParent as Control;
            int index = c.Name[1] - 49;

            if (_drawCircle)
            {
                b.Child = CreateCircle();
                b.UpdateLayout();
                _Cells[index].filledWith = FILLED_WITH_CIRCLE;
            }
            else
            {
                b.Child = CreateCross();
                b.UpdateLayout();
                _Cells[index].filledWith = FILLED_WITH_CROSS;
            }

            _numFilled++;

            if (_numFilled > 4)
                if (CheckIfGameOver())
                {
                    this.Cursor = Cursors.Arrow;
                    return true;
                }

            _drawCircle = !_drawCircle;

            if (_drawCircle)
                this.Cursor = Cursors.ArrowCD;
            else
                this.Cursor = Cursors.Cross;

            if (_numOfPlayers == 1)
                _itsMyTurn = !_itsMyTurn;

            return true;
        }

        void ItsMyTurn()
        {
            _itsMyTurn = true;

            if (_numFilled == 0)
                if ((++_myLastGoodStart) >= _goodStart.GetLength(0)) _myLastGoodStart = 0;

            int selectedCell = -1;

            if (_numFilled > 2)
            {
                if (_drawCircle)
                {
                    foreach (int[] m in _matches)
                    {
                        if (((_Cells[m[0]].filledWith & _Cells[m[1]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[2]].filledWith == 0)
                            selectedCell = m[2];
                        else if (((_Cells[m[0]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[1]].filledWith == 0)
                            selectedCell = m[1];
                        else if (((_Cells[m[1]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[0]].filledWith == 0)
                            selectedCell = m[0];

                        if (selectedCell >= 0)
                        {
                            AddChildIfEmpty(_Cells[selectedCell].border);
                            return;
                        }
                    }

                    foreach (int[] m in _matches)
                    {
                        if (((_Cells[m[0]].filledWith & _Cells[m[1]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[2]].filledWith == 0)
                            selectedCell = m[2];
                        else if (((_Cells[m[0]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[1]].filledWith == 0)
                            selectedCell = m[1];
                        else if (((_Cells[m[1]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[0]].filledWith == 0)
                            selectedCell = m[0];

                        if (selectedCell >= 0)
                        {
                            AddChildIfEmpty(_Cells[selectedCell].border);
                            return;
                        }
                    }
                }
                else
                {
                    foreach (int[] m in _matches)
                    {
                        if (((_Cells[m[0]].filledWith & _Cells[m[1]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[2]].filledWith == 0)
                            selectedCell = m[2];
                        else if (((_Cells[m[0]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[1]].filledWith == 0)
                            selectedCell = m[1];
                        else if (((_Cells[m[1]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CROSS) && _Cells[m[0]].filledWith == 0)
                            selectedCell = m[0];

                        if (selectedCell >= 0)
                        {
                            AddChildIfEmpty(_Cells[selectedCell].border);
                            return;
                        }
                    }
                    foreach (int[] m in _matches)
                    {
                        if (((_Cells[m[0]].filledWith & _Cells[m[1]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[2]].filledWith == 0)
                            selectedCell = m[2];
                        else if (((_Cells[m[0]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[1]].filledWith == 0)
                            selectedCell = m[1];
                        else if (((_Cells[m[1]].filledWith & _Cells[m[2]].filledWith) == FILLED_WITH_CIRCLE) && _Cells[m[0]].filledWith == 0)
                            selectedCell = m[0];

                        if (selectedCell >= 0)
                        {
                            AddChildIfEmpty(_Cells[selectedCell].border);
                            return;
                        }
                    }

                    if (_numFilled == 3)
                    {
                        if ((_Cells[0].filledWith & _Cells[8].filledWith) == FILLED_WITH_CIRCLE ||
                            (_Cells[2].filledWith & _Cells[6].filledWith) == FILLED_WITH_CIRCLE)
                        {
                            if (AddChildIfEmpty(_Cells[1].border) == false)
                                AddChildIfEmpty(_Cells[7].border);
                            return;
                        }
                    }
                }
            }

            if (_toBeStartedByMe && _numFilled < 3)
            {
                if (_goodStart[_myLastGoodStart].GetLength(0) >= _numFilled / 2)
                {
                    int[] probales = _goodStart[_myLastGoodStart][_numFilled / 2];

                    foreach (int i in probales)
                    {
                        if (_Cells[i].filledWith == 0)
                        {
                            AddChildIfEmpty(_Cells[i].border);
                            return;
                        }
                    }
                }
            }


            if (_Cells[4].filledWith == 0) selectedCell = 4;
            else if (_Cells[0].filledWith == 0) selectedCell = 0;
            else if (_Cells[2].filledWith == 0) selectedCell = 2;
            if (selectedCell >= 0)
            {
                AddChildIfEmpty(_Cells[selectedCell].border);
                return;
            }

            foreach (Cell c in _Cells)
            {
                if (c.filledWith == 0)
                {
                    AddChildIfEmpty(c.border);
                    return;
                }
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_isGameOver || _itsMyTurn)
                return;

            //this.ResizeMode = ResizeMode.NoResize;

            if (sender is Border)
            {
                if (AddChildIfEmpty(sender as Border) == true && _isGameOver == false)
                {
                    if (_numOfPlayers == 1)
                        ItsMyTurn();
                }
            }
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_numOfPlayers > 1)
                _itsMyTurn = false;

            _drawCircle = true;
            _isGameOver = false;
            _numFilled = 0;
            TB_GameOver.Visibility = Visibility.Hidden;

            foreach (Cell c in _Cells)
            {
                c.border.Child = null;
                c.filledWith = 0;
                (c.control.DataContext as BorderDC).IsBlinking = false;
            }

            _corssDataContext.Angle1 = 45;
            _corssDataContext.Angle2 = -45;
            _corssDataContext.IsRotating = false;

            _circleDataContext.IsRotating = false;

            this.Cursor = Cursors.ArrowCD;

            if (_numOfPlayers == 1 && _toBeStartedByMe)
                ItsMyTurn();
            else
                _itsMyTurn = false;
        }

        private void OnePlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            _numOfPlayers = 1;
            _itsMyTurn = false;
            _toBeStartedByMe = false;
            NewGameBtn_Click(sender, e);
        }

        private void TwoPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            _numOfPlayers = 2;
            _itsMyTurn = false;
            _toBeStartedByMe = false;
            NewGameBtn_Click(sender, e);
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
