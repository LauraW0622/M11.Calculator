namespace M11.Calculator
{
    internal partial class Form1 : Form
    {
        /*
        FirstNumberState first = new FirstNumberState();
        SecondNumberState second = new SecondNumberState();
        OperatorState operators = new OperatorState();
        ResultState equal = new ResultState();

        AbsState state = first;*/


        public Form1()
        {
            AbsState.f1 = this;

            InitializeComponent();

        }

        public AbsState state = new FirstNumberState();

        Add add = new Add();
        Subtract subtract = new Subtract();
        Divide divide = new Divide();
        Multiply multiply = new Multiply();

        Sqrt squareRoot = new Sqrt();
        Inversion inverse = new Inversion();
        Negation negation = new Negation();

        C c = new C();
        CE ce = new CE();

        Decimal dec = new Decimal();
        BackSpace back = new BackSpace();

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

        private void ceKey_Click(object sender, EventArgs e)
        {
            state = state.nextState(ce);
        }

        private void cKey_Click(object sender, EventArgs e)
        {
            state = state.nextState(c);
        }

        private void posNeg_Click(object sender, EventArgs e)
        {
            state = state.nextState(negation);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            state = state.nextState(squareRoot);
        }

        private void inverseX_Click(object sender, EventArgs e)
        {
            state = state.nextState(inverse);
        }

        private void decPoint_Click(object sender, EventArgs e)
        {
            state = state.nextState(dec);
        }

        private void backKey_Click(object sender, EventArgs e)
        {
            state = state.nextState(back);
        }
    }
}