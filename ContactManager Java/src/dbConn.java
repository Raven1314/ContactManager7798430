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
	
	
}
