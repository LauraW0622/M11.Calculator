namespace M11.Calculator
{
    internal partial class Form1 : Form
    {


        public Form1()
        {
            state.f1 = this;
            
            InitializeComponent();
        }

        //public FirstNumberState firstNumState = new FirstNumberState();
        //public SecondNumberState secondNumState = new SecondNumberState();
        //public ResultState resultState = new ResultState();
        //public OperatorState operatorState = new OperatorState();

        public AbsState state = new FirstNumberState();
        

        Add add = new Add();
        Subtract subtract = new Subtract();
        Divide divide = new Divide();
        Multiply multiply = new Multiply();

        private void zeroKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('0');
        }

        private void oneKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('1');
        }

        private void twoKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('2');
        }

        private void threeKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('3');
        }

        private void fourKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('4');
        }

        private void fiveKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('5');
        }

        private void sixKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('6');
        }

        private void sevenKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('7');
        }

        private void eightKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('8');
        }

        private void nineKey_Click(object sender, EventArgs e)
        {
            state = state.nextState('9');
        }

        private void addOp_Click(object sender, EventArgs e)
        {
            state = state.nextState(add);
        }

        private void subtractOp_Click(object sender, EventArgs e)
        {
            state = state.nextState(subtract);
        }

        private void multOp_Click(object sender, EventArgs e)
        {
            state = state.nextState(multiply);
        }

        private void divideOp_Click(object sender, EventArgs e)
        {
            state = state.nextState(divide);
        }

        private void equalOp_Click(object sender, EventArgs e)
        {
            state = state.nextState(new ResultState());
        }
    }
}