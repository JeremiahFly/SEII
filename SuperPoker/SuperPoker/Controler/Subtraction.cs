namespace SuperPoker.Controler {
	public class Subtraction : Operation {
		
		public double execute(double a, double b) {
			return System.Math.Abs(a - b);
		}
	}
}