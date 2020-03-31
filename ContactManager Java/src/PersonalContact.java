import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class PersonalContact extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;
	private JTextField textField_6;
	private JTextField textField_7;
	private JTextField textField_8;
	private JLabel lblNewLabel_1;
	private JLabel lblNewLabel_2;
	private JLabel lblNewLabel_3;
	private JLabel lblNewLabel_4;
	private JLabel lblNewLabel_5;
	private JLabel lblNewLabel_6;
	private JLabel lblNewLabel_7;
	private JLabel lblNewLabel_8;
	private JButton btnBusMigrate;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PersonalContact frame = new PersonalContact();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public PersonalContact() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1046, 630);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(41, 248, 968, 323);
		contentPane.add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		dbConn d = new dbConn();
		
		textField = new JTextField();
		textField.setBounds(102, 46, 99, 19);
		contentPane.add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setBounds(102, 86, 99, 19);
		contentPane.add(textField_1);
		textField_1.setColumns(10);
		
		textField_2 = new JTextField();
		textField_2.setBounds(73, 130, 128, 19);
		contentPane.add(textField_2);
		textField_2.setColumns(10);
		
		textField_3 = new JTextField();
		textField_3.setBounds(102, 175, 99, 19);
		contentPane.add(textField_3);
		textField_3.setColumns(10);
		
		textField_4 = new JTextField();
		textField_4.setBounds(286, 20, 110, 19);
		contentPane.add(textField_4);
		textField_4.setColumns(10);
		
		textField_5 = new JTextField();
		textField_5.setBounds(286, 64, 110, 19);
		contentPane.add(textField_5);
		textField_5.setColumns(10);
		
		textField_6 = new JTextField();
		textField_6.setBounds(286, 108, 110, 19);
		contentPane.add(textField_6);
		textField_6.setColumns(10);
		
		textField_7 = new JTextField();
		textField_7.setBounds(286, 152, 110, 19);
		contentPane.add(textField_7);
		textField_7.setColumns(10);
		
		textField_8 = new JTextField();
		textField_8.setBounds(286, 197, 110, 19);
		contentPane.add(textField_8);
		textField_8.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(15, 46, 77, 19);
		contentPane.add(lblNewLabel);
		
		lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(15, 87, 77, 19);
		contentPane.add(lblNewLabel_1);
		
		lblNewLabel_2 = new JLabel("Email");
		lblNewLabel_2.setBounds(15, 131, 48, 19);
		contentPane.add(lblNewLabel_2);
		
		lblNewLabel_3 = new JLabel("Personal Tel");
		lblNewLabel_3.setBounds(15, 176, 77, 19);
		contentPane.add(lblNewLabel_3);
		
		lblNewLabel_4 = new JLabel("Addr 1");
		lblNewLabel_4.setBounds(213, 23, 63, 19);
		contentPane.add(lblNewLabel_4);
		
		lblNewLabel_5 = new JLabel("Addr 2");
		lblNewLabel_5.setBounds(211, 67, 63, 19);
		contentPane.add(lblNewLabel_5);
		
		lblNewLabel_6 = new JLabel("Addr 3");
		lblNewLabel_6.setBounds(211, 111, 63, 19);
		contentPane.add(lblNewLabel_6);
		
		lblNewLabel_7 = new JLabel("Postcode");
		lblNewLabel_7.setBounds(211, 155, 63, 19);
		contentPane.add(lblNewLabel_7);
		
		lblNewLabel_8 = new JLabel("City");
		lblNewLabel_8.setBounds(213, 197, 63, 19);
		contentPane.add(lblNewLabel_8);
		
		btnBusMigrate = new JButton("Migrate to Business");
		btnBusMigrate.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		btnBusMigrate.setBounds(719, 170, 132, 27);
		contentPane.add(btnBusMigrate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(719, 125, 132, 27);
		contentPane.add(btnDelete);
		
		JButton btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setBounds(719, 81, 132, 27);
		contentPane.add(btnSaveSelected);
		
		JButton btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.setBounds(719, 42, 132, 27);
		contentPane.add(btnUpdateSelected);
		
		JButton btnAddNew = new JButton("Add New");
		btnAddNew.setBounds(890, 42, 132, 27);
		contentPane.add(btnAddNew);
		
		JButton btnSaveNew = new JButton("Save New");
		btnSaveNew.setBounds(890, 83, 132, 27);
		contentPane.add(btnSaveNew);
		
		JButton btnCancel = new JButton("Cancel");
		btnCancel.setBounds(890, 127, 132, 27);
		contentPane.add(btnCancel);
		
		JButton btnRefresh_7 = new JButton("Refresh");
		btnRefresh_7.setBounds(890, 172, 132, 27);
		contentPane.add(btnRefresh_7);
	}
}
