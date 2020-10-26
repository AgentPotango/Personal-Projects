/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package my.ibmsdrh;

import javax.swing.table.AbstractTableModel;

/**
 *
 * @author mbax2sb3
 */
public class RosterTableModel extends AbstractTableModel {
    private String[] columnNames = {"Monday", "Tuesday", "Wednesday",
                                    "Thursday", "Friday", "Saturday", "Sunday"};
    private Object[][] data;

    public RosterTableModel() {
        this.data = new Object[][]{
        {"<html>ID:101" + "<br/>" + "Start time - End time</html>", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102"}, 
        {"ID:101", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102"}, 
        {"ID:101", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102"}, 
        {"ID:101", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102", "ID:102"}
        };
    }
    
    @Override
    public int getColumnCount() {
        return columnNames.length;
    }
    
    @Override
    public int getRowCount() {
        return data.length;
    }
    
    @Override
    public String getColumnName(int col) {
        return columnNames[col];
    }
    
    @Override
    public Object getValueAt(int row, int col) {
        return data[row][col];
    }
    
    @Override
    public Class getColumnClass (int c) {
        return getValueAt(0, c).getClass();
    }
}
