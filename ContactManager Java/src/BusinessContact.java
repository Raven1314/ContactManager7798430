import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import javax.swing.JScrollPane;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTable;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class BusinessContact extends JFrame {
	private JTextField tfEmail;
	private JTextField tfCity;
	private JTextField tfPostcode;
	private JTextField tfAddr3;
	private JTextField tfAddr2;
	private JTextField tfAddr1;
	private JTextField tfLname;
	private JTextField tfBusTel;
	private JTextField tfFname;
	private JTable table;
	
	dbConn d = new dbConn();
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BusinessContact frame = new BusinessContact();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
	public void Refresh() {//refresh connection can be called and get Business Contacts
		table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
	}
	/**
	 * Create the frame.
	 */
	public BusinessContact() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1046, 632);
		getContentPane().setLayout(null);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(15, 46, 77, 19);
		getContentPane().add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(15, 87, 77, 19);
		getContentPane().add(lblNewLabel_1);
		
		tfEmail = new JTextField();
		tfEmail.setEditable(false);
		tfEmail.setColumns(10);
		tfEmail.setBounds(73, 130, 128, 19);
		getContentPane().add(tfEmail);
		
		JLabel lblNewLabel_2 = new JLabel("Email");
		lblNewLabel_2.setBounds(15, 131, 48, 19);
		getContentPane().add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Business Tel");
		lblNewLabel_3.setBounds(15, 176, 77, 19);
		getContentPane().add(lblNewLabel_3);
		
		JLabel lblNewLabel_8 = new JLabel("City");
		lblNewLabel_8.setBounds(213, 197, 63, 19);
		getContentPane().add(lblNewLabel_8);
		
		tfCity = new JTextField();
		tfCity.setEditable(false);
		tfCity.setColumns(10);
		tfCity.setBounds(286, 197, 110, 19);
		getContentPane().add(tfCity);
		
		tfPostcode = new JTextField();
		tfPostcode.setEditable(false);
		tfPostcode.setColumns(10);
		tfPostcode.setBounds(286, 152, 110, 19);
		getContentPane().add(tfPostcode);
		
		tfAddr3 = new JTextField();
		tfAddr3.setEditable(false);
		tfAddr3.setColumns(10);
		tfAddr3.setBounds(286, 108, 110, 19);
		getContentPane().add(tfAddr3);
		
		tfAddr2 = new JTextField();
		tfAddr2.setEditable(false);
		tfAddr2.setColumns(10);
		tfAddr2.setBounds(286, 64, 110, 19);
		getContentPane().add(tfAddr2);
		
		tfAddr1 = new JTextField();
		tfAddr1.setEditable(false);
		tfAddr1.setColumns(10);
		tfAddr1.setBounds(286, 20, 110, 19);
		getContentPane().add(tfAddr1);
		
		JLabel lblNewLabel_4 = new JLabel("Addr 1");
		lblNewLabel_4.setBounds(213, 23, 63, 19);
		getContentPane().add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Addr 2");
		lblNewLabel_5.setBounds(211, 67, 63, 19);
		getContentPane().add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("Addr 3");
		lblNewLabel_6.setBounds(211, 111, 63, 19);
		getContentPane().add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("Postcode");
		lblNewLabel_7.setBounds(211, 155, 63, 19);
		getContentPane().add(lblNewLabel_7);
		
		JButton btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.setBounds(719, 42, 132, 27);
		getContentPane().add(btnUpdateSelected);
		
		JButton btnAddNew = new JButton("Add New");
		btnAddNew.setBounds(890, 42, 132, 27);
		getContentPane().add(btnAddNew);
		
		JButton btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		btnSaveNew.setBounds(890, 82, 132, 27);
		getContentPane().add(btnSaveNew);
		
		JButton btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setEnabled(false);
		btnSaveSelected.setBounds(719, 82, 132, 27);
		getContentPane().add(btnSaveSelected);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(719, 126, 132, 27);
		getContentPane().add(btnDelete);
		
		JButton btnCancel = new JButton("Cancel");
		btnCancel.setEnabled(false);
		btnCancel.setBounds(890, 127, 132, 27);
		getContentPane().add(btnCancel);
		
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Refresh();
			}
		});
		btnRefresh.setBounds(890, 171, 132, 27);
		getContentPane().add(btnRefresh);
		
		JButton btnBusMigrate = new JButton("Migrate to Business");
		btnBusMigrate.setBounds(719, 171, 132, 27);
		getContentPane().add(btnBusMigrate);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(27, 250, 977, 333);
		getContentPane().add(scrollPane);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				
				tfFname.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				tfLname.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				tfEmail.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				tfBusTel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				tfAddr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				tfAddr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				tfAddr3.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				tfPostcode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
				tfCity.setText(table.getValueAt(table.getSelectedRow(),9).toString());
			}
		});
		scrollPane.setViewportView(table);
		
		Refresh();
		
		tfLname = new JTextField();
		tfLname.setEditable(false);
		tfLname.setColumns(10);
		tfLname.setBounds(91, 86, 110, 19);
		getContentPane().add(tfLname);
		
		tfBusTel = new JTextField();
		tfBusTel.setEditable(false);
		tfBusTel.setColumns(10);
		tfBusTel.setBounds(102, 175, 99, 19);
		getContentPane().add(tfBusTel);
		
		tfFname = new JTextField();
		tfFname.setEditable(false);
		tfFname.setColumns(10);
		tfFname.setBounds(91, 46, 110, 19);
		getContentPane().add(tfFname);
		
		
		btnCancel.addActionListener(new ActionListener() {///////////////////Cancel Editing///////////////////
			public void actionPerformed(ActionEvent e) {
				btnSaveSelected.setEnabled(false);
				btnCancel.setEnabled(false);
				btnBusMigrate.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnAddNew.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(true);
				
				tfFname.setEditable(false);
				tfLname.setEditable(false);
				tfEmail.setEditable(false);
				tfBusTel.setEditable(false);
				tfAddr1.setEditable(false);
				tfAddr2.setEditable(false);
				tfAddr3.setEditable(false);
				tfPostcode.setEditable(false);
				tfCity.setEditable(false);
			}
		});
		
		btnUpdateSelected.addActionListener(new ActionListener() {///////////UpdateSelected////////////
			public void actionPerformed(ActionEvent e) {
				
				btnSaveSelected.setEnabled(true);
				btnCancel.setEnabled(true);
				btnBusMigrate.setEnabled(false);
				btnUpdateSelected.setEnabled(false);
				btnAddNew.setEnabled(false);
				btnDelete.setEnabled(false);

				tfFname.setEditable(true);
				tfLname.setEditable(true);
				tfEmail.setEditable(true);
				tfBusTel.setEditable(true);
				tfAddr1.setEditable(true);
				tfAddr2.setEditable(true);
				tfAddr3.setEditable(true);
				tfPostcode.setEditable(true);
				tfCity.setEditable(true);
			}
		});
		
		
		btnSaveSelected.addActionListener(new ActionListener() {//////////////////Save Selected///////////////////
			public void actionPerformed(ActionEvent e) {
				
				if(!((tfFname.getText().isEmpty() || tfLname.getText().isEmpty()))) {

				String f = tfFname.getText();
				String l = tfLname.getText();
				String em = tfEmail.getText();
				String busTel = tfBusTel.getText();
				String addr1 = tfAddr1.getText();
				String addr2 = tfAddr2.getText();
				String addr3 = tfAddr3.getText();
				String postcode = tfPostcode.getText();
				String city = tfCity.getText();
				String id = table.getValueAt(table.getSelectedRow(), 0).toString();

				d.UpdateBusiness(f, l, em, busTel, addr1, addr2, addr3, postcode, city, id);
				Refresh();
				
				btnSaveSelected.setEnabled(false);
				btnCancel.setEnabled(false);
				btnBusMigrate.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnAddNew.setEnabled(true);
				btnDelete.setEnabled(true);

				tfFname.setEditable(false);
				tfLname.setEditable(false);
				tfEmail.setEditable(false);
				tfBusTel.setEditable(false);
				tfAddr1.setEditable(false);
				tfAddr2.setEditable(false);
				tfAddr3.setEditable(false);
				tfPostcode.setEditable(false);
				tfCity.setEditable(false);
				}
				else {
					JOptionPane.showMessageDialog(null,"Please enter First Name or Last Name");
					}
			}
		});
		
		btnAddNew.addActionListener(new ActionListener() {/////////////////Add New/////////////////
			public void actionPerformed(ActionEvent e) {
				btnBusMigrate.setEnabled(false);
				btnSaveNew.setEnabled(true);
				btnUpdateSelected.setEnabled(false);
				btnCancel.setEnabled(true);
				btnDelete.setEnabled(false);
				btnAddNew.setEnabled(false);

				
				tfFname.setEditable(true);
				tfLname.setEditable(true);
				tfEmail.setEditable(true);
				tfBusTel.setEditable(true);
				tfAddr1.setEditable(true);
				tfAddr2.setEditable(true);
				tfAddr3.setEditable(true);
				tfPostcode.setEditable(true);
				tfCity.setEditable(true);
				
				tfFname.setText("");
				tfLname.setText("");
				tfEmail.setText("");
				tfBusTel.setText("");
				tfAddr1.setText("");
				tfAddr2.setText("");
				tfAddr3.setText("");
				tfPostcode.setText("");
				tfCity.setText("");
			}
		});
		
		btnSaveNew.addActionListener(new ActionListener() {//////////////////Save New///////////////////
			public void actionPerformed(ActionEvent e) {
				if(!((tfFname.getText().isEmpty() || tfLname.getText().isEmpty()))) {
					
					
					String f = tfFname.getText();
					String l = tfLname.getText();
					String em = tfEmail.getText();
					String perTel = tfBusTel.getText();
					String addr1 = tfAddr1.getText();
					String addr2 = tfAddr2.getText();
					String addr3 = tfAddr3.getText();
					String postcode = tfPostcode.getText();
					String city = tfCity.getText();

					d.InsertBusiness(f, l, em, perTel, addr1, addr2, addr3, postcode, city);
					Refresh();

					btnCancel.setEnabled(false);
					btnBusMigrate.setEnabled(true);
					btnSaveNew.setEnabled(false);
					btnAddNew.setEnabled(true);
					btnUpdateSelected.setEnabled(true);
					btnDelete.setEnabled(true);

					tfFname.setEditable(true);
					tfLname.setEditable(true);
					tfEmail.setEditable(true);
					tfBusTel.setEditable(true);
					tfAddr1.setEditable(true);
					tfAddr2.setEditable(true);
					tfAddr3.setEditable(true);
					tfPostcode.setEditable(true);
					tfCity.setEditable(true);
					}
					
					else {
						JOptionPane.showMessageDialog(null,"Please enter First Name or Last Name");
					}
			}
		});
		
	}
}
