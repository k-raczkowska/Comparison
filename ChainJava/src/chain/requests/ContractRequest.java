package chain.requests;

import java.util.Date;

/**
 * Created by Karolina_2 on 2015-04-01.
 */
public class ContractRequest extends Request {

    Date waznosc;

    public ContractRequest(String nazwa, Date date, Date waznosc){
        this.nazwa = nazwa;
        this.date = date;
        this.waznosc = waznosc;
    }
}
