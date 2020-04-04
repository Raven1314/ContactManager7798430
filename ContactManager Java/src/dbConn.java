import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class dbConn {
    String connString = "jdbc:mysql://db212it.chcygaxzwjzx.us-east-1.rds.amazonaws.com/ContactManagerDB";
    String userName= "admin";
    String password ="db212it123";
    Connection conn = null;
    
    public dbConn() {///////////Connects the Database
    	try {
			conn = DriverManager.getConnection(connString, userName, password);
			System.out.println("Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Connection Failed");
		}

    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////            Personal Contact Start                       //////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
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
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////
    
	public void UpdatePersonal(String f,String l,String em,String perTel,String addr1,String addr2,String addr3,String postcode,String city,String id) 
	{
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
			cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void InsertPersonal(String f,String l,String em,String perTel,String addr1,String addr2,String addr3,String postcode,String city) 
	{
		
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
			cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void DeletePersonal(String id) {
		
		String sql = "{CALL deletePersonal(?)}";
		try {
			java.sql.CallableStatement cst = conn.prepareCall(sql);
			cst.setString(1, id);
			cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////  End personal Contact   ////////////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////      Business Contact         ////////////////////////////////////////////////////////////////////
	
	public ResultSet GetAllBusiness() {
		
		ResultSet rs = null;
		String sql="{CALL selectAllBusiness()}";
		try {
			java.sql.CallableStatement cst = conn.prepareCall(sql);
			rs = cst.executeQuery();
			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return rs;
	}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void UpdateBusiness(String f,String l,String em,String busTel,String addr1,String addr2,String addr3,String postcode,String city,String id) 
	{
		String sql="{CALL updateBusiness(?,?,?,?,?,?,?,?,?,?)}";
		try {
			
			java.sql.CallableStatement cst= conn.prepareCall(sql);
			cst.setString(1, id);
			cst.setString(2, f);
			cst.setString(3, l);
			cst.setString(4, em);
			cst.setString(5, busTel);
			cst.setString(6, addr1);
			cst.setString(7, addr2);
			cst.setString(8, addr3);
			cst.setString(9, postcode);
			cst.setString(10, city);
			cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void InsertBusiness(String f,String l,String em,String busTel,String addr1,String addr2,String addr3,String postcode,String city) 
	{
		String sql="{CALL insertBusiness(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= conn.prepareCall(sql);
			cst.setString(1, f);
			cst.setString(2, l);
			cst.setString(3, em);
			cst.setString(4, busTel);
			cst.setString(5, addr1);
			cst.setString(6, addr2);
			cst.setString(7, addr3);
			cst.setString(8, postcode);
			cst.setString(9, city);
			cst.executeQuery();
		}
		catch(SQLException e){
			e.printStackTrace();
		}
		

	}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void DeleteBusiness(String id) {
		
		String sql = "{CALL deleteBusiness(?)}";
		try {
			java.sql.CallableStatement cst = conn.prepareCall(sql);
			cst.setString(1, id);
			cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
