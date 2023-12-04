package GUI;
import javax.swing.*;

public class JLabelEx extends JFrame
{
	JPanel jp;
	JLabel jl1,jl2;
	public JLabelEx()
	{
		jp = new JPanel();
		add(jp);
		setTitle("JLabel");
		setSize(600,600);
		setVisible(true);
		
		jl1 = new JLabel("First Name: ");
		jl2 = new JLabel("Last Name: ");
		
		jp.add(jl1);
		jp.add(jl2);
	}
	public static void main(String[]args)
	{
		JLabelEx jlabel = new JLabelEx();
	}
}