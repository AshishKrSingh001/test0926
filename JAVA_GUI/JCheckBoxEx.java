package GUI;
import javax.swing.*;

public class JCheckBoxEx extends JFrame
{
	JPanel jp;
	JCheckBox music,dance,cricket,football;
	public JCheckBoxEx()
	{
		jp = new JPanel();
		music = new JCheckBox("Music");
		dance = new JCheckBox("Dance");
		cricket = new JCheckBox("Cricket");
		football = new JCheckBox("Football");
		
		jp.add(music);
		jp.add(dance);
		jp.add(cricket);
		jp.add(football);
		
		add(jp);
		setTitle("JCheckBox");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JCheckBoxEx jc = new JCheckBoxEx();
	}
}
