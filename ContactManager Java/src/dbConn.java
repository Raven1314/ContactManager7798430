import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class dbConn {
    String connString = "jdbc:mysql://db212it.chcygaxzwjzx.us-east-1.rds.amazonaws.com/ContactManagerDB";
    String userName= "admin";
    String password ="db212it123";
    Connection conn = null;
    
    public dbConn() {
    	try {
			conn = DriverManager.getConnection(connString, userName, password);
			System.out.println("Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Connection Failed");
		}

    }
    
	public ResultSet GetAllPersonal() {
		
		ResultSet rs = null;
		String sql="{CALL selectAllPersonal()}";
		try {
			java.sql.CallableStatement cst = conn.prepareCall(sql);
			rs = cst.executeQuery();
			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return rs;
	}
	
	public void UpdatePersonal(String f,String l,String em,String perTel,String addr1,String addr2,String addr3,String postcode,String city,String id) 
	{
		ResultSet rs = null;
		String sql="{CALL updatePersonal(?,?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= conn.prepareCall(sql);
			cst.setString(1, id);
			cst.setString(2, f);
			cst.setString(3, l);
			cst.setString(4, em);
			cst.setString(5, perTel);
			cst.setString(6, addr1);
			cst.setString(7, addr2);
			cst.setString(8, addr3);
			cst.setString(9, postcode);
			cst.setString(10, city);
			rs=cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	public void InsertPersonal(String f,String l,String em,String perTel,String addr1,String addr2,String addr3,String postcode,String city) 
	{
		ResultSet rs = null;
		String sql="{CALL insertPersonal(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= conn.prepareCall(sql);
			cst.setString(1, f);
			cst.setString(2, l);
			cst.setString(3, em);
			cst.setString(4, perTel);
			cst.setString(5, addr1);
			cst.setString(6, addr2);
			cst.setString(7, addr3);
			cst.setString(8, postcode);
			cst.setString(9, city);
			rs=cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	
	
}
