package com.example;

import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RegexUtility {

	/**
	 * Be sure to account for middle name, middle initial, and prefix (Mr, Ms, Miss, Mrs, Dr).  Ensure proper capitalization.
	 * @param name the name to check
	 * @return true if valid; otherwise false
	 */
	boolean isValidHumanName(String name){
        String Regex = "/(Dr. |Ms. |Miss |Mrs. |Mr. |)([A-Z][a-z]{0,} |)([A-Z][a-z]{0,} |)[A-Z][a-z]{0,}/gm";

        return name.matches(Regex);
    }
	

	/**
	 * Username must be at least 1 non-numeric character.  After the first character and before the '@' can be any alpha (any case)
	 * any numeric, and only the symbols '_' and '.'.
	 * The domain name section must contain at least a 1 character sub-domain.  Again the first character must be alpha (in either case)
	 * and the remaining characters can be alpha or numeric.  The top-level domain can be 3-4 alphanumeric characters of either case.
	 * @param email the email address to check
	 * @return true if valid; otherwise false
	 */
	boolean isValidEmailAddress(String email){
        String Regex = "/[A-Za-z0-9._]{1,}@[A-Za-z][A-Za-z0-9._]{0,}.[A-Za-z]{3,4}/gm";

        return email.matches(Regex);
    }
	
	
	/**
	 * Of the form CC-AAA-PPP-NNNN or C-AAA-PPP-NNNN or AAA-PPP-NNNN
	 * Where CC is the two digit country code,
	 * 		C is a one digit country code
	 * 		AAA is a three digit area code
	 *      NNNN is the four digit phone number
	 * research which digits are allowed in which blocks in phone numbers (some have minimum values)
	 * @param phone the phone number string to check
	 * @return true if valid; else false
	 */
	boolean isValidPhoneNumber(String phone){
        String regex = "/([0-9]{1,2}-|)[0-9]{3}-[0-9]{3}-[0-9]{4}/gm";

        return phone.matches(regex);
    }
	
	/**
	 * A US compliant SSN
	 * reserach what digits are allowed in which locations (some have minimum values)
	 * @param ssn
	 * @return
	 */
	boolean isValidSSN(String ssn){
        String Regex = "[0-9]{3}-[0-9]{2}-[0-9]{4}";

        return ssn.matches(Regex);
    }
			

	/**
	 * Validate that a given password matches the given complexity requirements
	 * @param password the password to check
	 * @param minLength the minimum length the password is allowed to be
	 * @param minUpper the minimum number of upper case alpha characters the password must have
	 * @param minLower the minimum number of lower case alpha characters the password must have
	 * @param minNumeric the minimum number of numeric characters the password must have
	 * @param minSymbols the minimum number of non-alphanumeric characters the password must have
	 * @return
	 */
	boolean validatePasswordComplexity(String password, int minLength, int minUpper, int minLower, int minNumeric, int minSymbols){
        StringBuilder sbRegex = new StringBuilder();
        String Regex = sbRegex.toString();

        return password.matches(Regex);
    }
	

	/**
	 * Get the content of all occurences of an html tag given it's name and the html string in which it occurs
	 * @param html the html string to be searched
	 * @param tagName the tagName for which the inner content should be returned
	 * @return
	 */
	String[] getHTMLTagsContents(String html, String tagName){
        String pat1 = "<" + tagName + ">";
        String pat2 = "</" + tagName + ">";

        String Regex = Pattern.quote(pat1) + "(.*?)" + Pattern.quote(pat2);
        Pattern p = Pattern.compile(Regex);

        ArrayList<String> matches = new ArrayList<String>();

        Matcher m = p.matcher(html);

        while(m.find()){
            matches.add(m.group(1));
        }

        return (String[]) matches.toArray();
    }


	/**
	 * For all occurrences of a link tag ("<a href=..") in the string html
	 * return the URL to which the link goes
	 * @param html the string to be searched
	 * @return an array of link destinations
	 */
	String[] getHTMLLinkURL(String html){
        String pat1 = "<a href='";
        String pat2 = "'";

        String Regex = Pattern.quote(pat1) + "(.*?)" + Pattern.quote(pat2);
        Pattern p = Pattern.compile(Regex);

        ArrayList<String> matches = new ArrayList<String>();

        Matcher m = p.matcher(html);

        while(m.find()){
            matches.add(m.group(1));
        }

        return (String[]) matches.toArray();
    }
}
