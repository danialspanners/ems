Create view v_supplier_ontime as select Su.Supplier_Name, PH.PO_No, PH.shipment_date, PL.transact_date from POHeader PH, POLine PL, Supplier SU
where PH.PO_ID = PL.PO_ID
and PH.Supplier_ID = SU.Supplier_ID
and PL.order_qty = PL.confirm_qty 

