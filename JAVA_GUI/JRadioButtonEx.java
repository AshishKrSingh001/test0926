package GUI;
import javax.swing.*;

public class JRadioButtonEx extends JFrame
{
	JPanel jp;
	JRadioButton male,female;
	ButtonGroup bg;
	public JRadioButtonEx()
	{
		jp = new JPanel();
		bg = new ButtonGroup();
		
		male = new JRadioButton("Male");
		female = new JRadioButton("Female");
		
		bg.add(male);
		bg.add(female);
		
		jp.add(male);
		jp.add(female);
		
		add(jp);
		setTitle("JRadioButton");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JRadioButtonEx jr = new JRadioButtonEx();
	}
}
