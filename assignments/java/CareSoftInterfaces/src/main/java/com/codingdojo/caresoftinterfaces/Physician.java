package com.codingdojo.caresoftinterfaces;

import java.util.ArrayList;
import java.util.Date;

import com.caresoft.clinicapp.HIPAACompliantUser;

public class Physician extends User implements HIPAACompliantUser {

    private ArrayList<String> patientNotes;
	
    
    //===Constructor===//
    
    public Physician(Integer id) {
    	super(id);
    }
	
    
    //===Methods===//

    public void newPatientNotes(String notes, String patientName, Date date) {
        String report = String.format(
            "Datetime Submitted: %s \n", date);
        report += String.format("Reported By ID: %s\n", this.id);
        report += String.format("Patient Name: %s\n", patientName);
        report += String.format("Notes: %s \n", notes);
        this.patientNotes.add(report);
    }
    
	@Override
	public boolean assignPin(int pin) {
		// TODO Auto-generated method stub
		int pinLength = String.valueOf(pin).length();
		
		if (pinLength == 4) {
			return true;
		} else {
		return false;
		}
	}
	
	@Override
	public boolean accessAuthorized(Integer confirmedAuthID) {
		// TODO Auto-generated method stub
		if (this.id == confirmedAuthID) {
			return true;
		} else  {
		return false;
		}
	}

    //===Getters & Setters===//

	public ArrayList<String> getPatientNotes() {
		return patientNotes;
	}

	public void setPatientNotes(ArrayList<String> patientNotes) {
		this.patientNotes = patientNotes;
	}
	

}
