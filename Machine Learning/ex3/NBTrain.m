function [conditionTables, priorProb] = NBTrain(AttributeSet, LabelSet)
format long
uniqueConditions = unique(LabelSet);
uniqueAttributes = unique(AttributeSet);
noOfExamples = size(AttributeSet,1);
noOfConditions = size(uniqueConditions,1);
noOfAttributes = size(AttributeSet,2);
noOfAttributeValues = size(uniqueAttributes,1);
noOfUniqueConditions = zeros(1,noOfConditions);
priorProb = zeros(1,noOfConditions);
conditionTables = cell(1,noOfAttributes);


for i = 1:noOfConditions
    noOfUniqueConditions(1,i) = sum(LabelSet == uniqueConditions(i,1));
    priorProb(1,i) = noOfUniqueConditions(1,i)/noOfExamples;
end

for i = 1:noOfAttributes
    conditionTables{1,i} = zeros(noOfAttributeValues,noOfConditions);
end    

%AttributeSet(h,i) =

for h = 1:noOfExamples
    for i= 1:noOfAttributes
        for j = 1:noOfAttributeValues
           if (AttributeSet(h,i) == uniqueAttributes(j,1))
               for k = 1:noOfConditions
                   if (LabelSet(h,1) == uniqueConditions(k,1)) 
                       addValue = 1/noOfUniqueConditions(1,k);
                       conditionTables{1,i}(j,k) = conditionTables{1,i}(j,k) + addValue;
                   end
               end
           end
        end
    end
end
                    
            
        
%each attribute has x number of values


%for i = 1:noOfAttributes
    %no Of Attribute Values in each column
 %   noOfAttributeValues(1,i) = size(unique(AttributeSet(:,i)),1);
%end








