import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import javafx.scene.control.TextField;
import net.proteanit.sql.DbUtils;

import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class PersonalContact extends JFrame {

	private JPanel contentPane;
	private JTextField tfFname;
	private JTextField tfLname;
	private JTextField tfEmail;
	private JTextField tfPerTel;
	private JTextField tfAddr1;
	private JTextField tfAddr2;
	private JTextField tfAddr3;
	private JTextField tfPostcode;
	private JTextField tfCity;
	private JLabel lblNewLabel_1;
	private JLabel lblNewLabel_2;
	private JLabel lblNewLabel_3;
	private JLabel lblNewLabel_4;
	private JLabel lblNewLabel_5;
	private JLabel lblNewLabel_6;
	private JLabel lblNewLabel_7;
	private JLabel lblNewLabel_8;
	private JButton btnRefresh;
	private JScrollPane scrollPane;
	private JTable table;
	
	
	dbConn d = new dbConn();//get connection

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
	public void Refresh() {//refresh connection can be called
		table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
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
		
		tfFname = new JTextField();
		tfFname.setEditable(false);
		tfFname.setBounds(102, 46, 99, 19);
		contentPane.add(tfFname);
		tfFname.setColumns(10);
		
		tfLname = new JTextField();
		tfLname.setEditable(false);
		tfLname.setBounds(102, 86, 99, 19);
		contentPane.add(tfLname);
		tfLname.setColumns(10);
		
		tfEmail = new JTextField();
		tfEmail.setEditable(false);
		tfEmail.setBounds(73, 130, 128, 19);
		contentPane.add(tfEmail);
		tfEmail.setColumns(10);
		
		tfPerTel = new JTextField();
		tfPerTel.setEditable(false);
		tfPerTel.setBounds(102, 175, 99, 19);
		contentPane.add(tfPerTel);
		tfPerTel.setColumns(10);
		
		tfAddr1 = new JTextField();
		tfAddr1.setEditable(false);
		tfAddr1.setBounds(286, 20, 110, 19);
		contentPane.add(tfAddr1);
		tfAddr1.setColumns(10);
		
		tfAddr2 = new JTextField();
		tfAddr2.setEditable(false);
		tfAddr2.setBounds(286, 64, 110, 19);
		contentPane.add(tfAddr2);
		tfAddr2.setColumns(10);
		
		tfAddr3 = new JTextField();
		tfAddr3.setEditable(false);
		tfAddr3.setBounds(286, 108, 110, 19);
		contentPane.add(tfAddr3);
		tfAddr3.setColumns(10);
		
		tfPostcode = new JTextField();
		tfPostcode.setEditable(false);
		tfPostcode.setBounds(286, 152, 110, 19);
		contentPane.add(tfPostcode);
		tfPostcode.setColumns(10);
		
		tfCity = new JTextField();
		tfCity.setEditable(false);
		tfCity.setBounds(286, 197, 110, 19);
		contentPane.add(tfCity);
		tfCity.setColumns(10);
		
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

		JButton btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setEnabled(false);
		btnSaveSelected.setBounds(719, 82, 132, 27);
		contentPane.add(btnSaveSelected);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(719, 126, 132, 27);
		contentPane.add(btnDelete);
		
		JButton btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		btnSaveNew.setBounds(890, 82, 132, 27);
		contentPane.add(btnSaveNew);
		
		JButton btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.setBounds(719, 42, 132, 27);
		contentPane.add(btnUpdateSelected);
		
		JButton btnAddNew = new JButton("Add New");
		btnAddNew.setBounds(890, 42, 132, 27);
		contentPane.add(btnAddNew);
		
		JButton btnCancel = new JButton("Cancel");
		btnCancel.setEnabled(false);
		btnCancel.setBounds(890, 127, 132, 27);
		contentPane.add(btnCancel);
		
		JButton btnBusMigrate = new JButton("Migrate to Business");
		btnBusMigrate.setBounds(719, 171, 132, 27);
		contentPane.add(btnBusMigrate);
		

		
		btnRefresh = new JButton("Refresh");////////////Refresh////////////////
		btnRefresh.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Refresh();//Call Refresh
			}
		});
		btnRefresh.setBounds(890, 171, 132, 27);
		contentPane.add(btnRefresh);
		
		
		

		btnCancel.addActionListener(new ActionListener() {//////////Cancel Editing///////////////////
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
				tfPerTel.setEditable(false);
				tfAddr1.setEditable(false);
				tfAddr2.setEditable(false);
				tfAddr3.setEditable(false);
				tfPostcode.setEditable(false);
				tfCity.setEditable(false);
			}
		});
		

		scrollPane = new JScrollPane();
		
		scrollPane.setBounds(27, 250, 977, 333);
		contentPane.add(scrollPane);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				tfFname.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				tfLname.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				tfEmail.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				tfPerTel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				tfAddr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				tfAddr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				tfAddr3.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				tfPostcode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
				tfCity.setText(table.getValueAt(table.getSelectedRow(),9).toString());

			}
		});
		scrollPane.setViewportView(table);
		
		
		
		btnDelete.addActionListener(new ActionListener() {////////////////////Delete////////////////
			public void actionPerformed(ActionEvent e) {
				try {
					
				    int dialogButton = JOptionPane.YES_NO_OPTION;
					int dialogResult = JOptionPane.showConfirmDialog (null, "Delete" +" " +	table.getValueAt(table.getSelectedRow(),1) +" "+table.getValueAt(table.getSelectedRow(),2),"Warning",dialogButton);
					//adds record information into confirmation box
					if(dialogResult == JOptionPane.YES_OPTION){//If user clicked yes, it will delete the record
						String id = table.getValueAt(table.getSelectedRow(), 0).toString();
						d.DeletePersonal(id);
						Refresh();					
						}
					
					else {
						//Does nothing
					}
			}
				catch(Exception e1){
					
				}

			}
				
		});
		
		
		
		btnSaveSelected.addActionListener(new ActionListener() {//////////////////Save Selected///////////////////
			public void actionPerformed(ActionEvent e) {
				String f = tfFname.getText();
				String l = tfLname.getText();
				String em = tfEmail.getText();
				String perTel = tfPerTel.getText();
				String addr1 = tfAddr1.getText();
				String addr2 = tfAddr2.getText();
				String addr3 = tfAddr3.getText();
				String postcode = tfPostcode.getText();
				String city = tfCity.getText();
				String id = table.getValueAt(table.getSelectedRow(), 0).toString();

				d.UpdatePersonal(f, l, em, perTel, addr1, addr2, addr3, postcode, city, id);
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
				tfPerTel.setEditable(false);
				tfAddr1.setEditable(false);
				tfAddr2.setEditable(false);
				tfAddr3.setEditable(false);
				tfPostcode.setEditable(false);
				tfCity.setEditable(false);
			}
		});
		
		
		btnSaveNew.addActionListener(new ActionListener() {//////////////////Save New///////////////////
			public void actionPerformed(ActionEvent e) {
				String f = tfFname.getText();
				String l = tfLname.getText();
				String em = tfEmail.getText();
				String perTel = tfPerTel.getText();
				String addr1 = tfAddr1.getText();
				String addr2 = tfAddr2.getText();
				String addr3 = tfAddr3.getText();
				String postcode = tfPostcode.getText();
				String city = tfCity.getText();

				d.InsertPersonal(f, l, em, perTel, addr1, addr2, addr3, postcode, city);
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
				tfPerTel.setEditable(true);
				tfAddr1.setEditable(true);
				tfAddr2.setEditable(true);
				tfAddr3.setEditable(true);
				tfPostcode.setEditable(true);
				tfCity.setEditable(true);
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
				tfPerTel.setEditable(true);
				tfAddr1.setEditable(true);
				tfAddr2.setEditable(true);
				tfAddr3.setEditable(true);
				tfPostcode.setEditable(true);
				tfCity.setEditable(true);
				
				tfFname.setText("");
				tfLname.setText("");
				tfEmail.setText("");
				tfPerTel.setText("");
				tfAddr1.setText("");
				tfAddr2.setText("");
				tfAddr3.setText("");
				tfPostcode.setText("");
				tfCity.setText("");
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
				tfPerTel.setEditable(true);
				tfAddr1.setEditable(true);
				tfAddr2.setEditable(true);
				tfAddr3.setEditable(true);
				tfPostcode.setEditable(true);
				tfCity.setEditable(true);
			}
		});
		
		Refresh();//Load data after page creates

	}
}
