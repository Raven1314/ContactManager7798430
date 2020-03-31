import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class ContactManager {

	private JFrame frame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ContactManager window = new ContactManager();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ContactManager() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 890, 550);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnBusiness = new JButton("Business Contact");
		btnBusiness.setBounds(504, 217, 183, 61);
		frame.getContentPane().add(btnBusiness);
		
		JButton btnPersonal = new JButton("Personal Contact");
		btnPersonal.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				PersonalContact pc = new PersonalContact();
				pc.setVisible(true);
			}
		});
		btnPersonal.setBounds(180, 217, 183, 61);
		frame.getContentPane().add(btnPersonal);
	}
}
