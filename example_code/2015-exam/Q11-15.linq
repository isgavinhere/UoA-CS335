/* Q11-15 */

var xml = XElement.Load(@"Q11-15.xml");

var Q11 = xml.XPathSelectElements("//dot[@colour='red']//x | //dot[@colour]//z");
// Matches all x elements that descend from dot elements with colour attribute 'red', and all z elements that descend from dot elements with any colour attribute.
var Q12 = xml.XPathSelectElements("//dot[not(@colour='red')]//x | //dot[not(@colour='blue')]//z");
// Matches all x elements that descend from dot elements that don't have colour attribute 'red', and all z elements that descent from dot elements that don't have colour attribute 'blue'.
var Q13 = xml.XPathSelectElements("//dot[@colour!='red']//x | //dot[@colour!='blue']//z");
// Matches all x elements that descend from dot elements that have a colour attribute that is not 'red', and all z elements that descend from dot elelents that have a colour attribute that is not 'blue'.
var Q14 = xml.XPathSelectElements("//dot[not(@colour!='red')]//x | //dot[not(@colour!='blue')]//z");
// Matches all x elements that descend from dot elements that have a either have no colour attribute, or colour attribute 'red', and all z elements that descend from dot elements that either have no colour attribute, or colour attribute 'blue'
var Q15 = xml.XPathSelectElements("//dot[not(@colour)]//x | //dot[not(@colour)]//z");
// Matches all x and z elements that descend from dot elements that do not have a colour attribute.

Console.WriteLine("Q11: {0}, Q12: {1}, Q13: {2}, Q14: {3}, Q15: {4}", Q11.Count(), Q12.Count(), Q13.Count(), Q14.Count(), Q15.Count()); // Q11: 4, Q12: 6, Q13: 4, Q14: 4, Q15: 2
